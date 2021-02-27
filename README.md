# .Net 5 Blazor WebAssembly Example

this is practical project made with .Net 5 Blazor web assembly as client app, And Asp.net Core API as server side. 
The goal is to demonstrate the capabilities of the Blazor.net. Also explain the possibility of designing and building the user interface of web and mobile applications with PWA capability.

In this project, I just focused on building the user interface by blazor. So I wrote it with the blazor client side (WASM) model.
Also the blazor server side model that will be added in the future.
## Screen Shots:
![Blog Posts - Index](Documents/screenshot/Index_FullPageScreenshot.png?raw=true)

## How to use:
### Install .Net5 SDK

- run server (Application.Server.API) project
  - cd Server\Application.Server.API
  - dotnet run
- run client (Blazor.WebAssembly.ClientApp)
  - cd Blazor.WebAssembly.ClientApp
  - dotnet run
- Open the http://localhost:5000/ in your browser (Firefox is recommended).

## Extra notes:
### The Server API :
#### Provide a simple blog service for you. This service provides the following capabilities to your clients:
 - Includes a controller and CRUD (Create, Read, Update, Delete) related functions via the Http protocol and REST
 - Paged output for receiving large amounts of data (PagedResponse<T>). Such as receiving blog posts based on page and number of records (in json format).
  - for example: http://localhost:5001/blog?page=1&pageSize=10
 - Basic Separation of input and output models via Dto
 
 ### Blazor WASM (SPA Front-End Application)
 #### Provide Web Assembly client, with the ability to download and run in the user's browser. Server independent
 Include pages for displaying and managing blog posts, Communicate with the server api's
  - Design based on Razor components And C# capabilities for ui management / functionality.
    - bootstrap 4 library
    - Reusable Razor components. with model binding.
    - No dependence on javascript, I tried to use C # as much as possible.
  - Ability to paginate data and asynchronous loading/rendering ui. such as images, larg objects.
  - Ability to change the application theme. Between dark and light modes with a simple method. (Alpha, Under Construction)
  
  ### To test loading speed and download photos, thumbnail images of posts are randomly generated from an online site, for each post.
  You can add example post't by click on "Fill with demo data" button.
  
  TODO:
  - Ability to add new post
  - Ability to Edit a post
  - Ability to remove a post
  - Ability to view a post
  - Ability to like a post, increase view per each viewer
  - Ability to comment in posts
  - Ability to store data into a database (in memory -> ef core + sqlite)
  - Make PWA APP
