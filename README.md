# WEB315_Fall22_Assignment1
 Mobiles Webapp

Name: Het Patel
Student I'd: 0805024
Date: 03/06/2022

For this assignment,I use Mobiles theme.

---------------------------------------------------------------------------------------------------

For this assignment, My column list is,
1. Brand: which company produce the phone.
2. Model: specific phone model like iPhone 12.
3. Release Year: original release year of the Mobile.
4. Price: Actual price of the phone.
5. Network: Supported Network for the Mobile like 2G,4G or 5G.
6. Display size: Size of display of the phone.

---------------------------------------------------------------------------------------------------

Default Welcome Page edited

1. Theme name added
2. Author name added
3. Date and time added on welcome page

---------------------------------------------------------------------------------------------------

Models name for this webapp is Mobiles.cs.

---------------------------------------------------------------------------------------------------

Nuget Command use for this assignment:
1. dotnet new webapp -o Mobiles  --no-https
2. cd Mobiles -change directory
3. dotnet watch run
4. dotnet tool install --global dotnet-ef
5. dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
6. dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
7. dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
8. dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
9. dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

---------------------------------------------------------------------------------------------------

Command to scafhold the page
>dotnet-aspnet-codegenerator razorpage -m Mobilephones -dc MyMobileListContext -udl -outDir Pages/Mobiles --referenceScriptLibraries -sqlite

---------------------------------------------------------------------------------------------------

Database and Migration added from this command
1. dotnet ef migrations add InitialCreate
2. dotnet ef database update

