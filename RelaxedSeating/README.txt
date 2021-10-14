~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*******************************************Relaxed Seating README*********************************************
Date: 2021/10/09
Time: 3:11PM
-Readme frpm last session did not save, Initial Relaxed Seating web app instantiated!
-Updated page title and link to Relaxed Seating
-Tested app to make sure changes were applied

Time: 3:18PM
-Crated initial Model, View, and Controller files for Relaxed Seating, next will be updating them to reflect
 the theme of chairs, starting with Model file
-Updated Model to include, chairId, name, material, dateMade, and price of chair. Want to include a section
 for images but further reasearch is needed.

 Date: 2021/10/13
 Time: 8:32PM
 -Last commit while working from class did not work, Readme not saved either,
  earlier updated layout for application to reflect Relaxed Seating, had an issue with migrating and updating
  database, recieved help from Andrww, Eric and Abdullah: I needed to specify the context of which database
  to update.
Time: 8:35PM
-needed to remove Rating field from model class because I will re add it after the database is created as 
 another field.

Time: 10:13PM
-spent past 2 hours looking through css to find where to update font-family, have used ctrl-f to search for
 the selector, inspected code to see if change had been been made, no success so far, will keep trying...

Time: 11:36PM
-had to re scaffold the Chairs Controller due to last session not saving...

Time: 12:03AM
-Testing the app and no CRUD appeared! I AM SO LOST!!!

Time: 12:26AM
-FINALLY found my mistake: when updating _layout.cshtml I forgot to change the asp Controller property!
-Taking a sleep break...

Date: 2021/10/14
Time: 10:03AM
-Going to seed the database with 10 entries...

Time: 10:38AM
-Finished creating the SeedData.cs file with all the chair items, updated Program.cs to use the Initializer
 when the database is empty
-Tested the app to make sure the database was seeded and it was!
-Decided to test the login function: created an account with my email, while the send email confirmation
 function was not enabled it allowed me to confirm my email from the app, email was registered and the
 account was created!
-next, going to update the display of the propeties on the app
-Updated DateMade to Date Made, updated Price to decimal, had an issue where TypeName was not found, solved by
 adding using System.ComponentModel.DataAnnotations.Schema

Time: 10:55AM
-Created a search function within the ChairsController.cs file which would take in a string and return objects
 containing that string, added the function in a form object in the Chairs/Index.cshtml file. Tested function
 and was successful!
-Next going to add a search by Material function

Time: 11:20AM
-Completed adding search by Material function by creating ChairMaterialViewModel.cs and creating properties 
 for the Chair Material view, updated Index.cshtml to display the function, tested and was succesful!
-next going to add the rating field as well as the category field since it did not save from the previous 
 session...

Time: 2:32Pm
-Tried updating the database to include Category and Rating but recieved an error due to me forgetting to 
 update the CRUD to accept these properties, will update them now and test again...

Time: 4:05PM
-Had an issue where after I updated the CRUD and Updated the database, a blank page would load when I ran
 the app...I solved this by deleting the entire database and CRUD items, re-Scaffolded the project and
 initialized the database, Rating field was added with this re-do
-now have to re-add the search functions.
-Re-added both Material and Name search functions, tested and they worked.

Time: 4:27PM
-Next will be adding validation for each property...
-Name and Material are both required and must contain only letters up to 40 characters, for Price, a range
 from 1-100 and DataType Currency added and Rating contains a range from 1 - 5
-All controllers and functions appear to be working properly, now to alter the CSS a little bit more and 
 add some images

**************************************************************************************************************
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~