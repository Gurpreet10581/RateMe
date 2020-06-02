## RateMeMVC
Eleven Fifty Academy Red Badge Final Project

## Requirements

* Come up with an idea for an application that will use a minimum of 3 custom data tables
* Including at least one Foreign Key relationship
* Create a wireframe of the application and review it with an instructor
* Build out an n-tier structured MVC (think ElevenNote) with the following tiers
* Data: This layer houses your classes that relate to the DB (POCOs, Identity, etc)
* Models: This layer houses the reusable models for the rest of the layers
* Services: This layer is where you’ll have most of your heavy backend logic
* WebMVC: This is where the front end (Controllers, Views, Styles, etc) will be
* Deploy to Azure
* Link to deployed site on your Portfolio
* Repository has a README.md associated with the project

## Mission Statement

RateMe allows users to visit existing reviews for movie, music, and show. A user gets the ability to add, edit, and delete the entertainment type posted by them. RateMe displays entertainment details, all the reviews, and calculates an average rating received from the reviews. RateMe advises the best type of entertainment for a user so they never regret the time spent. 

## Author

* Gurpreet Singh 

## Important Project Links

* Project Planning Template- https://docs.google.com/document/d/1A7xFJ4p2yYGh7l4mt2egtDO2GHircLvTES48ZO-QJas/edit#
* WireFrame- https://docs.google.com/spreadsheets/d/1IOC8X4w8hTlshqqw_lasCmFXgBd050zqmceKyVw7AvU/edit#gid=0

## Steps to follow for proper implementation  

RateMe has 4 classes- Movie, Music, Show, and Review. Review class is connected with the other three classes for application to work properly. All the classes offer a variety of functionality to the users and narrow down their search. Users must register and login to enjoy all the features of this MVC.

Once logged in, a user has to ability to see all the reviews posted by other users for an existing movie, music, and show. All the users are authorized to add a new review to the existing entertainment type. If their search is non-existing then the user must create their Movie, Music, or Show to post a review. Search functionality is available to users for quick results and Sort functionality helps users identify the entries created by them. 

The use of different attributes and dependency helps users to be redirected to through different pages and experience the right display property. Formatting and Popup messages are used to guide users with current changes made and the next step to their search. The main motive of RateMe is to make the user experience pleasant and quick so they can select entertainment according to their choice or current mood. 

## Resources Implemented

* ASP.NET MVC 5- Working with Files- https://www.mikesdotnetting.com/article/259/asp-net-mvc-5-with-ef-6-working-with-files
* Bind Multiple Moodels on a View- https://www.codeproject.com/Articles/1108855/ways-to-Bind-Multiple-Models-on-a-View-in-MVC
* Implementing Uniqueness or Unique Key Attribute- https://www.codeproject.com/Articles/1130342/Best-Ways-of-Implementing-Uniqueness-or-Unique-K
* DateTime Issues- https://www.codeproject.com/Tips/1078167/DateTime-Issue-In-MVC
* Working with Enums- https://odetocode.com/blogs/scott/archive/2012/09/04/working-with-enums-and-templates-in-asp-net-mvc.aspx
* Adding a New Field- https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-aspnet-mvc4/adding-a-new-field-to-the-movie-model-and-table
* Implement Search and Sort- https://www.c-sharpcorner.com/UploadFile/219d4d/implement-search-paging-and-sort-in-mvc-5/
* Adding Search and Sort- https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/sorting-filtering-and-paging-with-the-entity-framework-in-an-asp-net-mvc-application
