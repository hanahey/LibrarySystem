CONTENTS OF THIS FILE
---------------------
*IMPORTANT*: All the instances of ¡®data source¡¯ in SQL connection strings where data source =¡¯LENOVO-PC\\SQLEXPRESS¡¯ must be changed to the name of the server where you stored the database backup file. 
  
-----Introduction-----
-Main functions
This Library Management System helps the Librarian perform tasks with ease by providing access to the following: 
Search for Books, Search for Availability Dates, Borrow Books Form, Return Books Form, Reserve Books Form, Maintain Books Information (Create, Retrieve, Update, Delete), Maintain Members Information (Create, Retrieve, Update, Delete), Generate Reports (Latest Borrow Receipt, List of Books, List of Members) 
- Scope
This Library Management System is designed for a traditional library where the only user of the system is the Staff. Thus, all functions are made with the Staff in mind and their work process.

 -----Requirements-----
You will need Visual Studio and SQL Server Management Studio to run this program.
The SA47Team11ALibraryDB.bak file will need to be restored on your SQL Server Management Studio before the program can be run on Visual Studio. 
Please ensure that the SA47Team11ALibraryDB database is added to your Data Connection in Visual Studio.
-----Recommended modules-----
1.Algorithm
There is a special algorithm for generating MemberID. All MemberIDs have 5-digits. A new MemberID is created based on the last MemberID in the database using this formula: 
eg. if the last Member ID is ¡®11110¡¯, the next generated MemberID will be ¡®11124¡¯)
Step 1. Delete the last digit from 11110 to get a four digit number:1111.
Step 2. Add 1 to 1111: 1112.
Step 3. Use the formula: remainder=1st +2nd*2+3rd*3+4th*4)%10;
[1st: 1st digit ; 2nd: 2nd digit; 3nd: 3nd digit ; 4th: 4th digit (of 1112); The remainder is 4.]
Step 4: The remainder will be the 5th digit of the new MemberID,which is 11124.
2.Functions
- Validation checks to remind users to avoid typing errors, etc. For added convenience, there are different MessageBox messages for different types of errors to guide the user when an invalid value is input.
- Login control: Before login, you can only use the search function. After login, the system will display the name of the user and the user will then be able to use all the system functions.
- User-friendly interface which includes tooltips, shortcuts, etc.
3.Logic(code)
- Using Transaction: When a Borrow Transaction is completed, a new transaction will need to be added into the ¡®IssueTran¡¯ table in the database and the ¡®NumberBorrowed¡¯ of the book borrowed must be increased by 1 in the ¡®Books¡¯ table. 
As these are both simultaneous activities, they have been saved as a Transaction so there will be no discrepancies if the server connection breaks before both tables are updated successfully.
- Using Sub-query:Makes use of a sub-query to efficiently retrieve the ¡®TransactionID¡¯ of the latest transaction from the database when generating Borrow Receipt.
- Using Parameters in sqlcommand.

 -----Troubleshooting----- 
If there is still trouble viewing the data after restoring the database:
As this program makes use of not only datasets but also typed datasets using the SA47Team11ALibraryDB database, please ensure that the dataset is properly created.



