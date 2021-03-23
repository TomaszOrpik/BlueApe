import Link from 'next/link'

export default function generatePage(data, pageData) {
    return (
        <div>
            <div>
                <div className="topBar">
                    <div className="leftSide">
                        <Link href="/">
                            <a>
                            <div className="logo">
                            <img src={data.BlogDocument.BlogDetails.LogoUrl} height="70" />
                        </div>
                            </a>
                        </Link>
                        {
                            data.BlogDocument.Pages.map((page) => (
                                <div className="pageLink">
                                    <Link key={Math.random()} href={`/${page.Title}`}>
                                        <a>{page.Title}</a>
                                    </Link>
                                </div>
                            ))
                        }
                    </div>

                    <div className="rightSide">
                        <div className="iconBox">
                            <Link key={Math.random()} href={data.BlogDocument.BlogDetails.InstagramLink}>
                                <a>
                                    <img src="./Assets/instagram.svg"
                                        height="70"
                                        width="30" />
                                </a>
                            </Link>
                        </div>
                        <div className="iconBox">
                            <Link key={Math.random()} href={data.BlogDocument.BlogDetails.TwitterLink}>
                                <a>
                                    <img src="./Assets/twitter.svg"
                                        height="70"
                                        width="30" />
                                </a>
                            </Link>
                        </div>
                        <div className="iconBox">
                            <Link key={Math.random()} href={data.BlogDocument.BlogDetails.FacebookLink}>
                                <a>
                                    <img src="./Assets/facebook-app-symbol.svg"
                                        height="70"
                                        width="30" />
                                </a>
                            </Link>
                        </div>
                    </div>
                </div>

                <div className="bottomBar">
                    <div className="title">
                        {data.BlogDocument.BlogDetails.Title}
                    </div>
                    <div className="categoryContainer">
                        {
                            data.BlogDocument.Categories.map(category => (
                                <div className="catBox">
                                    <span>{category}</span>
                                </div>
                            )
                            )
                        }
                    </div>
                </div>

                {pageData}

                <footer className="footer">
                    <span className="footerSpan">© 2021 All Rights Reserved. Powered by BlueApe</span>

                </footer>
            </div>
            <style jsx>{`
                  .topBar {
                    position: fixed;
                    top: 0;
                    left: 0;
                    width: 100%;
                    height: 75px;
                    background-color: ${data.BlogDocument.BlogDetails.BackgroundColor};
                    display: flex;
                    flex-direction: row;
                    border-bottom: 1px solid #e8e8e8;
                    z-index: 200;
                }
                .bottomBar {
                    height: 250px;
                    width: 100%;
                    position: absolute;
                    top: 75px;
                    left: 0;
                    background: linear-gradient(0deg, rgba(0,0,0,0) 0%, ${data.BlogDocument.BlogDetails.BackgroundColor} 99%);
                }
                .categoryContainer {
                    position: absolute;
                    top: 150px;
                    left: 0;
                    width: 100%;
                    height: 100px;
                    text-align: center;
                    display: flex;
                    flex-direction: row;
                    align-items: center;
                    justify-content: center;
                }
                .catBox {
                    margin: 0 20px;
                    font-size: 25px;
                    font-weight: 700;
                    color: ${data.BlogDocument.BlogDetails.SecondaryColor};
                    cursor: pointer;
                }
                .catBox:hover {
                    color: ${data.BlogDocument.BlogDetails.PrimaryColor};
                }
                .title {
                    position: absolute;
                    top: 70px;
                    width: 100%;
                    color: ${data.BlogDocument.BlogDetails.SecondaryColor};
                    font-family: 'Dancing Script', cursive;
                    font-size: 75px;
                    text-align: center;
                    cursor: default;
                    font-weight: 900;
                }
                .leftSide {
                    width: calc(100% - 150px);
                    display: flex;
                    flex-direction: row;
                }
                .rightSide {
                    width: 150px;
                    display: flex;
                    flex-direction: row;
                }
                .logo {
                    width: auto;
                    height: 70px;
                    cursor: pointer;
                }
                .logo:hover {
                    background: rgb(168,168,168);
                    background: ${data.BlogDocument.BlogDetails.SecondaryColor};
            
                }
                .pageLink {
                    font-size: 18px;
                    font-weight: 700;
                    line-height: 70px;
                    text-align: center;
                    padding-right: 10px;
                    padding-left: 10px;
                    cursor: pointer;
                    color: white;
                }
                .pageLink:hover {
                    background: rgb(168,168,168);
                    background: ${data.BlogDocument.BlogDetails.SecondaryColor};
                }
                .customA {
                    color: #fff;
                    text-decoration: none;
                }
                .customA:hover {
                    background: rgb(168,168,168);
                    background: ${data.BlogDocument.BlogDetails.SecondaryColor};
                }
                .iconBox {
                    position: relative;
                    width: 50px;
                    color: white;
                    cursor: pointer;
                    padding-left: 10px;
                }
                .iconBox:hover {
                    background: rgb(168,168,168);
                    background: ${data.BlogDocument.BlogDetails.SecondaryColor};
                }
                .iconBox > img {
                   left: 10px;
                    position: absolute;
                }
                a, a:hover {
                    color: white;
                    text-decoration: none;
                }
                
                .footer {
                    width: 100%;
                    height: 100px;
                    border-top: 1px solid #eaeaea;
                    display: flex;
                    justify-content: center;
                    align-items: center;
                    background-color: ${data.BlogDocument.BlogDetails.BackgroundColor}
                  }
                  .footerSpan {
                    text-align: end;
                    width: 100%;
                    margin-right: 10%;
                    color: lightgray;
                  }`}</style>
        </div>
    )
}
