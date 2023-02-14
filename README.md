# Calculator
This is a simple calculator. I used .Net 6.
It has a controller with 4 Get functions to calculate. They get two numbers and return the result. If a problem happens, they return Bad Request code(400).
These functions have some descriptions to show their details on Swagger. For example, summary and parameters.
Every funation in this controller, calls its function in Server side to calculate.(interface of the service and then the class of the service)
I run this project and open in Swagger. Description and results are shown.
![picture1](https://user-images.githubusercontent.com/9986831/218884212-0c18eba2-5b19-43d9-8d5f-4a640e656193.JPG)
![picture2](https://user-images.githubusercontent.com/9986831/218884242-4fd39d36-3e00-4f17-862f-8fa97c446bd4.JPG)
