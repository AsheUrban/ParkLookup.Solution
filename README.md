# Week 13 Independent Project: Build Your Own API

#### Custom built API offering useful information on state and national parks in the Pacific Northwest.

#### By Ashe Urban

## Technologies Used

* _C#_
* _Entity Framework_
* _SQL Database_
* _dotnet_
* _Markdown_

## Description

_This API was designed aid sharing information about some of our most beautiful PNW parks._

_This API includes data on the following properties:_

* _Name_
  * _Name of park, without state or national park attached_

* _Type_
  * _National Park, State Park, or National Park and Preserve_
  
* _Location_
  * _Alaska, Washington, Oregon, California, Idaho_

* _Features_
  * _Details about the unique benefits of each specific place_

_For best results querying one property at a time, will return best results. If evaluating for two or more properties it is reccommended that two or more api calls are made and results appended together._

## Notes:

_This api includes full CRUD functionality and includes existing data migrations._

## Link to Git Hub Repository & Lesson Details

https://github.com/AsheUrban/ParkLookup.Solution

https://epicenter.epicodus.com/courses/968/code_reviews/5865

### Naming Conventions

* _Production Database:_ park_lookup
* _Main Project Folder:_ ParkLookup.Solution

## Setup/Installation Requirements

* _Clone or download repository to your local._
* _Cd into ParkLookup and run dotnet restore, dotnet build to confirm the project has no errors._
* _Touch appsettings.json and add the following configuration:_

<pre>{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[park_lookup];uid=root;pwd=[password];"
  }
}</pre>

* _Run dotnet ef migrations add Initial and dotnet ef database update to build database._
* _Then use dotnet watch run to run web application._

_NOTE:_ [password] should be replaced by your password. Do not include square brackets in final configuration.

## Known Bugs

* _Swagger has been partially implemented. API works, but swagger documentation does not._

## License

* MIT

## Contact Information

_Please contact us with any questions or contribuitions, ashe@goldentongue.com._

Copyright(c) August 2022 Ashe Urban