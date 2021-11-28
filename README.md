# Ollibraria
Ol'Libraria is an web application for customer to buy books, and for the shop owner to manage books. This website was made by ASP.NET and was developed with Domain Drive Design (DDD) architecture. Which means this application uses layers such as:

1. View -- to show information to the user and interpret their commands.
2. Controller -- to validate all input from the view layer.
3. Handler -- to handle all business logic required in the application such as query from database.
4. Repository -- to give access to the database and model layer by referencing preexisting domain objects.
5. Factory -- for encapsulating all complex object creation.
6. Model -- for representing concepts in the business, and their relations with one another.

Ol'Libraria was made in Visual Studio, uses SQL Server Express LocalDB, means the database is included within the project and there's no need for external connection. This web application also incorporates features such as input validation that will be triggered if a user entered an invalid input.

# Startup Guide
1. Install Microsoft's Visual Studio.
2. Open the [Ollibraria.sln](Ollibraria.sln) in Visual Studio.
3. Open [Login.aspx](Ollibraria/View/Login.aspx) in Visual Studio's editor and run the program.

# Entity Relationship Diagram for Ollibraria's Database
![](pic/0database.jpg)

Below is the preview and/or flow of the application:
# Login Page
This page is the landing page of the website where the user will attempt to log in to the website. Your role in the web application will be determined by your username and password. An administrator have their username and password set as 'admin' and 'admin' respectively.

# Register Page
This page allows guests to register themselves as Ollibraria’s members. Will display an error if user input is invalid such as if the user input phone number with anything that isn't a numerical value.

# Home (as Member)


# Home (as Administrator)


# View Medicines Page (as Member)


# View Medicines Page (as Administrator)


# View Carts Page


# Add to Cart Page


# Profile Page


# Update Profile Page


# Change Password Page


# View Transaction History Page


# Insert Medicine Page


# Update Medicine Page


# View Users Page


# View Transaction Report Page

