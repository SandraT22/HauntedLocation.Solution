# Haunted Locations API

#### By  Sandra Tena

#### A simple API that allows the user access to a database of haunted locations in the US.   

---


## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _MySQL Workbench_
* _Entity Framework_
*_Swashbuckle.AspNetCore_
---
## A simple API the allows the user access to a database of haunted locations in the US. Each location within the database contains the Name, Keyword, City, Address, Description and Link to the locations website. 

---
## Documentation

#### API Endpoints:
* Get/api/v1/Locations/Version
* Get/api/v1/Locations/All
* Get/api/v1/Locations/Query
* Post​/api​/v1​/Locations
* Get/api/v1/Locations/{id}
* Put/api/v1/Locations/{id}
* Delete/api/v1/Locations/{id}
#### Further Exploration: 
* Swagger: "is a language-agnostic specification for describing REST APIs. It allows both computers and humans to understand the capabilities of a REST API without direct access to the source code."
_Resource: https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-6.0&viewFallbackFrom=aspnetcore-50_
* Swagger impplemented by running $ dotnet new webapi --framework net5.0 in the terminal. 
* Swagger runs automatically after following the steps below (editing appsettings.json, running $ dotnet restore, and running $ dotnet run).

## Setup and Installation Requirements
**This Setup assumes you have GitBash and MySQL Workbench pre-installed.   
If needed, please navigate to these links:  
https://git-scm.com/download/  
Download Git and follow the setup wizard.  
https://dev.mysql.com/downloads/workbench/  
Download MySQL Workbench, follow the setup wizard & create a localhost server on port 3306**


*Note: Keep track of your username and password, this will be used in the connection link under,*  
"**SQL Workbench Configuration**" > "2. Insert the following code:"

<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/SandraT22/HauntedLocation.Solution
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,   
<strong>$ git clone https://github.com/SandraT22/ParksLookup.Solution.git</strong>
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "HauntedLocations" directory  
   <pre>HauntedLocation.Solution
   └── HauntedLocations
    └── appsetting.json</pre>
<li> Insert the following code: <br>

<pre>{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=hauted_locations;uid=[YOUR UID HERE];pwd=[YOUR PASSWORD HERE];"
  }
}
}</pre>
<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>In root directory of project folder "ParksLookup", run  
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<li>Then run <strong>$ dotnet ef database update</strong>

<ol> 
  <li>Open SQL Workbench.
  <li>Navigate to "haunted_locations" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the tables, you should see <strong>locations</strong>.
  
</details>

<details>
<summary><strong>To Run</strong></summary>
click the play button towards the top of your Visual Studio screen. 
</details>
<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* No known bugs 

## License
MIT


Copyright (c) 2022 Sandra Tena 

## Contact Information
_If you have any questions or concerns, please feel free to reach out to me. Thank you!_ 