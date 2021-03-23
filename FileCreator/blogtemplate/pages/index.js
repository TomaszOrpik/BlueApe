import Head from 'next/head'
import styles from '../styles/Home.module.css'
import useSWR from 'swr'
import generatePage from '../Layout/layout'
import fetch from 'unfetch'
import Link from 'next/link'


const main = function (posts, primaryColor) {
  return (
    <main className="main">
      <Link href={"/" + posts[0].Title}>
        <a>
          <img src={posts[0].ImageUrl} />
        </a>
      </Link>
      {
        posts.slice(1).map(post =>
        (
          <div key={Math.random()} className="bodySquare">
            <div className="squareBase normalCursor row">
              <div className="left col-6">
                <Link href={"/" + post.Title}>
                  <a>
                    <div className="imageContainer">
                      <img src={post.ImageUrl} />
                    </div>
                  </a>
                </Link>
              </div>
              <div className="right col-6">
                <Link href={"/" + post.Title}>
                  <a className="blackFont"><h1>{post.Title}</h1></a>
                </Link>
                <span>{post.Intro}</span>
                <h3>{post.Date}</h3>
              </div>
            </div>
          </div>)

        )
      }
      <style jsx>{`
          h1 {
            font-size: 40px;
        }
        span {
            font-size: 26px;
        }
        h3 {
            font-size: 25px;
        }
        .containerBody {
            width: 100%;
        }
    
        .bodySquare {
            width: 75%;
            height: 300px;
            margin-top: 5%;
        }
    
        .squareBase {
            width: 125%;
            height: 250px;
        }
        .normalCursor {
            cursor: default !important;
        }
        .blackFont {
            color: black;
            font-weight: 700;
        }
        .blackFont:hover {
          color: ${primaryColor};
        }

      .imageContainer {
        width: 100%;
      }
      .imageContainer > img {
        width: 100%;
        height: auto;
      }

      
      .main {
        padding: 5rem 0;
        flex: 1;
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
      }`}</style>
    </main>
  );
}

export default function Home() {
  const fetcher = url => fetch(url).then(r => r.json());
  const { data, error } = useSWR('/api/blogData', fetcher);

  if (error) return <div>failed to load</div>
  if (!data) return <div>loading...</div>

  return (
    <div className={styles.container}>
      <Head>
        <title>Create Next App</title>
        <link rel="icon" href="/favicon.ico" />
      </Head>
      <body>
        {generatePage(data, main(data.BlogDocument.Posts, data.BlogDocument.BlogDetails.PrimaryColor))}
      </body>
    </div>
  )
}
