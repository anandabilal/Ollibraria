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

Entitiy Relationship Diagram (ERD) for the Ollibraria's application database. Which shows how each model interact with one another and what values they store inside of them.
Below is the preview and/or flow of the application:

# Login Page
![](pic/1login.jpg)

This page is the landing page of the website where the user will attempt to log in to the website. Your role in the web application will be determined by your username and password. An administrator have their username and password set as 'admin' and 'admin' respectively.

# Register Page
![](pic/2register.jpg)

This page allows guests to register themselves as Ollibraria’s members. Will display an error if user input is invalid such as if the user input phone number with anything that isn't a numerical value.

# Home (as Member)
![](pic/3home1.jpg)

After success logged in, the user will be redirected to the home page and this page is only accessible by logged-in users. If you're a Member then you will be shown the menu to the picture above.


# Home (as Administrator)
![](pic/3home2.jpg)

The Home menu but as an administrator opens new menus that are only accessible as an Administrator. Those menu are shown above.


# View Books Page (as Member)
![](pic/4viewbooks1.jpg)

This page allows users to see all of Ollibraria’s books information, fetched from the database. The user will be redirected to this page when they clicked the View Books Button provided at the Home Page. As a member you can add these books to the cart.

# View Books Page (as Administrator)
![](pic/4viewbooks2.jpg)

View Books as an Administrator is almost the same as Member, but instead of the button adding books to the cart, it will instead allow you to edit or delete those books from the database.

# View Carts Page
![](pic/5viewcarts.jpg)

This page displays all books that have been added into the current logged-in user’s shopping cart. Cart will show informations about the book the user is about to checkout, such as name, price, quantity, sub total, and grand total.

# Add to Cart Page
![](pic/6addtocart.jpg)


# Profile Page
![](pic/7profile.jpg)


# Update Profile Page
![](pic/8updateprofile.jpg)


# Change Password Page
![](pic/9changepassword.jpg)


# View Transaction History Page
![](pic/10viewtransactionhistory.jpg)


# Insert Books Page
![](pic/12insertbook.jpg)


# Update Books Page
![](pic/11updatebook.jpg)


# View Users Page
![](pic/13viewusers.jpg)


# View Transaction Report Page
![](pic/14viewtransactionreport.jpg)

