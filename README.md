# Discount.Calculator
Discount Calculator Project

The Project is Web API Project And Build in .net core 3.1


you need visual studion 2019 or .net runtime 5.0 to run this project


when will you run this Project by default a swager UI page open and give details of the API
To Get the Price List First of All You need Authenticate the APP


To Authenticate Call the Login Action method and pass the userName and Password
Once you call the login api a jwt token is returned 
you need to click to authenticate the swager click on the authentication Button in swagger UI and Passing Bearer+jwt token 
(which you got int the login method ) 



If you are calling it from postMan/fiddler then  you need call the "https://localhost:5001/api/Auth/Login" first and passing UserId and Pasword as json forma this API will return a jwt token
For calculating price you need to call "https://localhost:5001/api/DiscountCalculator/GetPrice?gram=10&price=10&discountAmount=0" API and you can change the value of query parameter
You also need that Jwt token i.e generated in Login API in header


This Project user in-memory db ,The demo user is creted in seeder function and user is created during the start the application 


Also a Unit Test are written for /GetPrice API


This Web API app has handled exception by middleware and also a swagger implementation
