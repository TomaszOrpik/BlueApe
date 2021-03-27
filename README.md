# BlueApe

Website builder created in Web Assembly technology.

# Introduction

BlueApe it's fullstack application which main functionality is creating custom blogs by application users. App is scripted mainly in C# and JavaScript languages. User thanks to BlueApe Blog Generator can create fully functional blogs with own database, subpages and styling. Pages generated like this can be even deployed and later edited through editor or custom coded in Javascript. 
<kbd>![blog selection](https://user-images.githubusercontent.com/54088860/112734998-8dd71600-8f49-11eb-8010-10d9d0150b5e.jpg)</kbd>

### Table of contents

**[1 BlueApe API](#1-blueape-api)**  
[1.1 General Info](#11-general-info)  
[1.2 Technologies](#12-technologies)  
[1.3 Endpoints](#13-endpoints)  
[1.4 Setup](#14-setup)  
**[2 File Creator](#2-file-creator)**  
[2.1 General Info](#21-general-info)  
[2.2 Technologies](#22-technologies)  
[2.3 Endpoints](#23-endpoints)  
[2.4 Setup](#24-setup)  
**[3 BlueApe UI](#3-blueape-ui)**  
[3.1 General Info](#31-general-info)  
[3.2 Technologies](#32-technologies)  
[3.3 Features](#33-features)  
[3.4 Setup](#34-setup)  
**[4 BlueApe Template](#4-blueape-template)**  
[4.1 General Info](#41-general-info)  
[4.2 Technologies](#42-technologies)  
[4.3 API](#43-api)  
[4.4 Setup](#44-setup)  
[4.5 Deployment](#45-deployment)  
**[5 Others](#5-others)**  
[5.1 Report Bug and improvments](#51-report-bug-and-improvments)  
[5.2 License](#52-license)  
[5.3 Contact](#53-contact)  


# 1 BlueApe API

### 1.1 General Info

Written in C# Api created to manage users blogs and accounts. Using ASP.NET WebAPI technology, api connects to mongo database, where it store and pass all data send from the UI. Using Entity framework and Identity framework api verifies users trying to access front end application based on they existence in database and logged in time with Json Web Token technology.

### 1.2 Technologies

Api is programmed in .net Core 5, ASP.NET WebAPI technology and C# language. Main libraries and frameworks used by application:
* Microsoft.AspNetCore.Identity
* Microsoft.AspNetCore.Identity.MongoDB
* Microsoft.AspNetCore.Authentication.JwtBearer
* Microsoft.EntityFrameworkCore
* Microsoft.OpenApi
* System.IO
* System.Linq
* System.Text
* System.Reflection

### 1.3 Endpoints

Endpoints utilized by application:
| resource      | requirements        |result        |
|:--------------|:--------------------|:-------------|
| Get `api/v1/Blogs/LookForBlog/:name` | name | Returns true if blog exist in database, otherwise false |
| Get `api/v1/Blogs/GetUserBlogs:/name` | User Name | Returns from database all blogs created by passed user |
| Post `api/v1/Blogs/CreateBlog` | BlogDocument | Creates in database new collection named after passed blog data, with all passed values and in users collection new user, with read/write access for this blog |
| Get `api/v1/Blogs/GetBlogData/:name` | name | Gets from database data of blog with passed name |
| Put `api/v1/Blogs/UpdateBlogData` | BlogDocument | Updates passed blog document in collection |
| Delete `api/v1/Blogs/DeleteBlog/:name` | name | Deletes from database blog with specific name |
| Get `api/v1/Blogs/LookForPost/:blogName/:postName` | Blog Name, Post Name | Looks in blog data with specific name, pointed post, returns true if exist, otherwise false |
| Get `api/v1/Blogs/getPostData/:blogName/:postName` | Blog name, Post name | Returns from pointed blog collection data of specific post |
| Get `api/v1/Blogs/GetPageData/:blogName/:pageName` | Blog name, Page name | Returns from pointed blog collection data of specific page |
| Post `api/v1/Blogs/AddPostData` | BlogDocument | Updates passed blog document in collection |
| Post `api/v1/Blogs/AddPageData` | BlogDocument | Updates passed blog document in collection |
| Put `api/v1/Blogs/UpdatePostData` | BlogDocument | Updates passed blog document in collection |
| Put `api/v1/Blogs/UpdatePageData` | BlogDocument | Updates passed blog document in collection |
| Delete `api/v1/Blogs/DeletePostData/:blogName/:postName` | Blog name, Post name | Removes post with specific name from the pointed blog |
| Delete `api/v1/Blogs/DeletePageData/:blogName/:pageName` | Blog name, Page name | Removes page with specific name from the pointed blog |
| Get `api/v1/Users/UserData` | JwtToken | Authorize user |
| Post `api/v1/Users/Register` | userModel | Adds passed user to database |
| Post `api/v1/Users/Login` | userModel | Verify if passed user exist in database, then verify token, then return ok |

### 1.4 Setup

To work correctly app requires [.net Core 5](https://dotnet.microsoft.com/download/dotnet/5.0) and [Visual Studio 2019](https://visualstudio.microsoft.com/pl/downloads/)
* Download repository
* Open BlueApe solution file
* Debug or Build in Visual Studio BlueApeAPI

# 2 File Creator

### 2.1 General Info

Node.js + Express.js API utilize to manage data directly on server. Main function of app is to generate endpoints, to easy manage images and generated blog data. Thanks to elastic files management functions of node.js - application can save files posted from front-end app on server, sending direct urls to files and manage blog data writing and downloading.

### 2.2 Technologies

Api is programmed in node.js + express.js frameworks with JavaScript language. Frameworks and libraries used in api:
* fs-extra
* body-parser
* express-fileupload
* cors
* adm-zip
* mongodb
* nodemon

### 2.3 Endpoints

Endpoints utilized by application:
| resource      | requirements        |result        |
|:--------------|:--------------------|:-------------|
| Get `/` | None | Display index page |
| Get `/config/:name` | Blog name | Generates json file with passed name blog data stored in database |
| Get `/staticPage/:name` | Blog name | Generates blog repository in next.js with json file in place of database connection |
| Get `/dynamicPage/:name` | Blog name | Generates blog repository in next.js with api getting blog data from database |
| Post `/saveImage` | File name, base64 string | Saves base64 string on server end returns link to generated png image |
| Delete `/deleteImage/:name` | Image name | Deletes from server png image with passed name |
| Post `/saveJpgImage` | File name, Base64 string | Saves base64 string on server end returns link to generated jpg image |
| Delete `/deleteJpgImage/:name` | image name | Deletes from server jpg image with passed name |

### 2.4 Setup

To work correctly App requires node.js installed:
* Download repository
* Run `npm install`
* Start server with `npm run start`

# 3 BlueApe UI

### 3.1 General Info

Created with Blazor Web Assembly with C# language, application to create and manage blogs. Thanks to WASM technology application is easy accessible and installable on any device. Also app is secured by MS Identity and JsonWebToken technologies. User interface with function of live reloading makes designing blog realy intuitive. After design is ready, user can manage content of the website with pages/posts build in editor. This way created website is easy exportable in form of static page without own backend or dynamic content website with own MongoDB collection containing or important styling/content data. Exported websites are ready for deployment to the [Vercel](https://vercel.com/) platform.

### 3.2 Technologies

Application is programmed in .net Core 5, Blazor Web Assembly technology with C# language. Frameworks and libraries used in api:
* Microsoft.AspNetCore.Authorization
* Microsoft.JSInterop
* Radzen.Blazor
* Blazored.LocalStorage
* Blazored.TextEditor

### 3.3 Features

Application main features:
* Login/register access system with timeout automatic logging out, based on json web token
<kbd>![loginPage](https://user-images.githubusercontent.com/54088860/112735038-d42c7500-8f49-11eb-9dae-2cc925ec03a5.jpg)</kbd>
* Easy access to designed blogs
<kbd>![blog selection](https://user-images.githubusercontent.com/54088860/112734998-8dd71600-8f49-11eb-8010-10d9d0150b5e.jpg)</kbd>
* Styling selection with live preview
<kbd>![webCreation](https://user-images.githubusercontent.com/54088860/112735092-4735eb80-8f4a-11eb-8a19-39d381cc01d0.gif)</kbd>
* Pages/Post edition with build in HTML editor
<kbd>![pageCreation](https://user-images.githubusercontent.com/54088860/112735102-56b53480-8f4a-11eb-9523-f7104095390a.gif)</kbd>
* Downloading designed blog with one click
<kbd>![blogExport](https://user-images.githubusercontent.com/54088860/112735109-67fe4100-8f4a-11eb-86ab-3bbeab2ebac5.gif)</kbd>

### 3.4 Setup

To work correctly app requires [.net Core 5](https://dotnet.microsoft.com/download/dotnet/5.0) and [Visual Studio 2019](https://visualstudio.microsoft.com/pl/downloads/)
* Download repository
* Open BlueApe solution file
* run `npm install`
* run `npm run start`
* Open BlueApe solution file
* Debug or Build in Visual Studio BlueApeAPI
* Debug or Build in Visual Studio BlueApeAUI

# 4 BlueApe Template

### 4.1 General Info

Stand-alone Website created with BlueApe Web Designer. Web-app is generated in JavaScript language and is using Next.js framework to work. Depends on user preferences application have own MongoDB Collection in database, and is easy to deploy through [Vercel](https://vercel.com/) platform.
<kbd>![templateImage](https://user-images.githubusercontent.com/54088860/112735080-2c637700-8f4a-11eb-9c39-425457c3a200.jpg)</kbd>

### 4.2 Technologies

Application is created with JSX programming language. Frameworks and libraries used:
* React
* React-dom
* next.js
* bootstrap 5
* mongodb
* swr
* unfetch

### 4.3 API

Website got build in api functionality under adress `/api/blogData`. Api have different functionality based on static/dynamic page type selected by user:
* in static mode - app generates BlogDocument.json file with database collection saved in, api in this mode access json file and gets all data from it 
* in dynamic mode - api access mongoDB collection created specially for this website, for security purpose application uses generated account with unique name and password, to make sure, that blogs data will be accessible only by dedicated template

### 4.4 Setup

To work correctly App requires node.js installed:
* Create application through BlueApe Web Designer
* Run `npm install`
* Run `npm run build`
* Start server with `npm run start` or `npm run dev`

### 4.5 Deployment

To deploy generated website:
* Create GitHub repository with website
* Login to Vercel platform and deploy website directly from git repository
For more detailed instruction follow [this link.](https://nextjs.org/learn/basics/deploying-nextjs-app/github)

# 5 Others

### 5.1 Report Bug and improvments

You can report encountered bugs or send ideas for improvement [here](https://github.com/TomaszOrpik/BlueApe/issues)

### 5.2 License

Application was uploaded under GENERAL PUBLIC LICENSE for more information [check license file](https://github.com/TomaszOrpik/BlueApe/blob/main/LICENSE) link to license

### 5.3 Contact

Feel free to [Contact me!](https://github.com/TomaszOrpik)
