import useSWR from 'swr'
import generatePage from '../Layout/layout'
import fetch from 'unfetch'
import { useRouter } from 'next/router'
import styles from '../styles/Home.module.css'

const main = function(page, primaryColor) {
  return (
    <div>
    <img className="postImage" src={page.ImageUrl} />
  <div className="container">
    <div className="postHeaders">
        <h3 className="postHead">{page.Categories.join(', ')}</h3>
        <h1 className="postTitle">{page.Title}</h1>
        <h3 className="dynamicColor">{page.Date}</h3>
    </div>
    {page.Content}
  </div>
    <style jsx>{`
    .postHead {
      font-size: 35px; 
      font-weight: 700; 
      color: ${primaryColor};
    }
    .dynamicColor {
      font-size: 25px;
      font-weight: 700;
    }
    .postTitle {
      font-size: 70px;
    }
    .pageHeader {
        width: calc(100% - 60px);
        padding-right: 60px;
        height: 50%;
    }

    .postImage {
        width: 100%;
    }
    `}</style>
  </div>
  )
}

export default function handler(req, res) {
  const fetcher = url => fetch(url).then(r => r.json());
  const router = useRouter();
  const { data, error } = useSWR('/api/blogData', fetcher);

  if (error) return <div>failed to load</div>
  if (!data) return <div>loading...</div>

  const { pid } = router.query;
  let page = data.BlogDocument.Pages.find(p => p.Title === pid);
  if (!page) page = data.BlogDocument.Posts.find(p => p.Title === pid);
    return (
      <div className={styles.container}>
        {generatePage(data, main(page, data.BlogDocument.BlogDetails.PrimaryColor))}
    </div>
    )
  }