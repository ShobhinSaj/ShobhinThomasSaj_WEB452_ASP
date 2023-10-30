## WEB452(DEVELOP WEB APPS IN ASP.NET) Assignment #2


**Description & General Notes**

An MVC Web app built using C# and ASP.NET visual studio.
*******************************************************************

This readme will take you through the process of building an ASP.net WEB APP in Visual Studio for the WEB452(DEVELOP WEB APPS IN ASP.NET) Course.
A presentation file has been provided by the instructor with steps to follow, to complete the first part of Assignment 2.

2023-10-28 @10.30am Created a new dot new ASP.net core web application with authentication type set to individual user accounts based on core 5.0.

@10.45am  Inspected the Areas folder which has the Identity folder in it and the default HomeController and ErrorModel.

@10.55am  Tried executing the web app with breakpoints at Actions Index() and Privacy(). 

@11.00am Created a new branch in existing Github repo for ASP assignments and named it Assignment2 and files were pushed to the branch.

@11.10am Visited the website Bootswatch.com which has custom themes for the webapp. Themes listed out were indeed overwhelming but I've decided to go with the theme Darkly since it
somewhat resembles with the kali linux os ui.

@11.20am Replaced default bootstrap.css file with bootstrap from bootswatch.com and replaced site.css with file provided.
Modified nav element class names to navbar-dark and bg-primary
Removed text-dark class from anchor tag

@11.35am Modified _LoginPartial.cshtml as per instructions in file provided 

@11.50am Added additional stylesheets and scripts provided to _Layout.cshtml
Added code for a dropdow menu in _Layout.cshtml, but for some reason the dropdown was not working on execution
Figured out i need to add a bootstrap script for the dropdown menu to work
```
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
```
Dropdown menu is working alright now

@12.00am Added 3 new .NET Core class libraries named ShobhinsBooks.DataAccess,ShobhinsBooks.Models and ShobhinsBooks.Utility
Copied Data folder to DataAccess library

@12.15am Microsoft.EntityFrameworkCore.Relational v5.0.17 and Microsoft.EntityFrameworkCore.SqlServer v5.0.17 installed via Nuget Packet Manager.

@12.25am Made changes to directory as instructed in file provided.
New Area called Customer and Admin added to Areas
References to _Layout.cshtml changed in  _ViewStart.cshtml.
Changed pushed to Github repo.
******************************************************************

**Testing**

![Screenshot_WlcmePage](https://github.com/madmax117/ShobhinThomasSaj_WEB452_ASP/blob/Assignment2/img/Homepage.png)

The web app has been tested to work as intended.
*******************************************************************

**Author**

Author: Shobhin Thomas Saj

Student number: 0819372

Purpose: WEB452 Assignment#2


