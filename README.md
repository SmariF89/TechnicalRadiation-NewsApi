# TechnicalRadiation-NewsApi
A .NET Core RESTful web API that offers CRUD routes for news items, categories and authors.

## Prerequisites
  Make sure to have .NET CLI installed.

## Start-up
  Using your favorite shell, browse to TechnicalRadiation.WebApi and enter:
    
    dotnet build && dotnet run
    
  The project will build and run afterwards on localhost, port 5000.
  
## Usage
  Use any capable software you like, such as Postman, to create HTTP-requests to send to the running server.
  Please refer to the routes inside TechnicalRadiation.WebApi/Controllers/<EntityName>Controller.cs to learn
  which routes are applicable.

## Note
  The data of this API is stored in RAM during runtime rather than in a database. This is done on purpose.
