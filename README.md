# BlueApe
Web assembly based website blog template editor

# Introduction

BlueApe it's fullstack application which main functionality is creating custom blogs by application users. App is scripted mainly in C# and JavaScript languages. User thanks to BlueApe Blog Generator can create fully functional blogs with own database, subpages and styling. Pages generated like this can be even deployed and later edited through editor or custom coded in Javascript. 

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
* Debug or Build in Visual Studio

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
fgfgfgj
### 3.1 General Info
gfjgfjgf
### 3.2 Technologies
ghjghjg
### 3.3 Features
hgfgfhhgf
### 3.4 Setup
jhgghjghj
# 4 BlueApe Template
fghjhgf
### 4.1 General Info
fgjgfg
### 4.2 Technologies
gjfgjhf
### 4.3 API
gkhgghk
### 4.4 Setup
gffgh
# 5 Others

### 5.1 Report Bug and improvments
You can report encountered bugs or send ideas for improvement [here](https://github.com/TomaszOrpik/BlueApe/issues)

### 5.2 License
Application was uploaded under GENERAL PUBLIC LICENSE for more information [check license file](https://github.com/TomaszOrpik/BlueApe/blob/main/LICENSE) link to license

### 5.3 Contact
Feel free to [Contact me!](https://github.com/TomaszOrpik)
