﻿# Desktop-Time-Management-Application

                                     #Description:
This is a Windows Presentation Foundation that displays a user's module code, name, credit of the module, class hours per week, number of weeks in the semester, and start date for the first week of the semester. 
Then the software application calculates self-study per week for each module.  
The application records the number of hours they spend working on a specific module on a certain date. By the end of the application, user will be shown a graph. The software shall display how many hours of self-study remain for each module for the current week.

                                   #ABOUT SOFTWARE:
Written using API Web Application C# and requires the user to use Visual Studio 2019, 2021, 2022 or Jetbrain Rider
Features:
•	Runs on any system such as Windows, Linux, and MAC OS(Tested)
•	Is an API Web Application 
•	A User-Manual is provided to be given a view on how the application works and to see the outlet of the application.
•	Runs on the Following Coding editors: Visual Studio Code, Visual Studio 2019, 2020, 2021, 2022 and JetBrain Rider.
 
  
                                       ##Table of Contents

1)	##[Code Application]
2)	##[Installation]
3)	##[build&runSoftware]
4)	##[Previous feedback]


                                    1. ##Code Application
This application runs on Visual Studio 2019, 2021, 2022 and Jetbrain Rider

                                    2. ## Installation:
Use the following website to download: visual studio 2019, Visual Studio 2022, Visual Studio Code, JetBrain Rider

                                    3. ##Build & Run:
1)	User downloads & extracts code from the zip folder. Open the folder. Open the file and open POE.sln. Open with Visual Studio. The user will then be directed to the Visual studio.
2)	Open Microsoft SQL Server Management Studio. Copy and connect to the Database Engine. Create a new database named POE and paste everything from my database named Data, create a new query, and save as Data or database and save it on the folder. Then proceed to Visual Studio. On the left, side there is a server Explorer. Click on it and connect to the server’s name of your database. Paste your Database’s Engine name.
3)	Select the database name POE and test the connection. 
4)	Thereafter right-click on the database name and select properties or Alt-Enter. Copy Connection String.
5)	Paste the connection on HomeControlle.cs on two parts.  First part SqlConnection sql = new SqlConnection("Data Source=DESKTOP-PCB0HSD\\SQLEXPRESS;Initial Catalog=POE;Integrated Security=True"); and Second part string connection = "Data Source=DESKTOP-PCB0HSD\\SQLEXPRESS;Initial Catalog=POE;Integrated Security=True";
6)	User must then click the name IIS Express (Google Chrome or Microsoft Edge)

                                     4. ##Previous feedback:

1) add hash password
2) Implemented a UML Diagram
# Desktop-Time-Management-Application
