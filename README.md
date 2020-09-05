# SimpleCoreREST_API
Create an API based on REST architecture using dotnet framework or dotnet core, which takes an input payload having a nested structure and returns a flattened structured response.

URL:
POST REQUEST - http://localhost:8080/route
Input:
•	Input payload structure has the following hierarchy – 
o	Route -> Stop -> Object
•	A route can have multiple stops
•	A stop can have multiple objects
•	Sample input (JSON)
 
Output:
•	Response should be a flattened denormalized structure of the input
•	Sample Output (JSON)
 
