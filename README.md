# Calculator
This is a simple calculator. I used .Net 6.
It has a controller with 4 functions to calculate. They get two numbers and return the result. If a problem happens, they return Bad Request code(400).
These functions have some descriptions to show their details on Swagger. For example, summary and parameters.
Every funation in this controller, calls its function in Server side to calculate.(interface of the service and then the class of the service)
I run this project and open in Swagger. Description and results are shown.
