RESTful inventory tracking system

1)	Create an application using VS (REST API application)

2)	Initial approach was to connect to a SQL database, but SQL could not be installed on the computer so went with making Lists

3)	Did some research on how REST APIs work found this article which was very helpful in explaining the basics.

•	https://pusher.com/tutorials/understanding-rest-api/#:~:text=It%20specifies%20how%20applications%20interact,application%20to%20interact%20with%20another.

4) The below article helped me implement API using lists

•	 https://www.kindsonthegenius.com/how-to-create-rest-api-in-net-using-c-and-visual-studio/

5)	Create REST APIs

Add an API controller using Entity Framework (ItemsController.cs)
Add a model class Inventory.cs

When we add the API controller with read/write actions, it automatically gives us the different instances of the APIs like:
•	HTTP GET method to list all items from the list and get the details on the products
•	HTTP PUT method to update the items in the list
•	HTTP POST method to add new items to the list
•	HTTP DELETE method to delete items from the list

6)	Tested using Advanced REST client and Postman
All unit testing was positive
https://localhost:7075/api/Inventory  (please make sure the ‘I’ is uppercase in Inventory)

7)	Having trouble with updating new items that were just added to the list using PUT.
However, I do understand that they don’t really exist in the List Inventory and that’s why gives an error of cannot be non-negative. 

