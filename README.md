# Verse of the Day - .NET Core 
MVC .NET Core 3.1 Web Application built with Entity Framework Core
& SQL Lite

![Verse of the Day](https://user-images.githubusercontent.com/13399339/111725456-18769180-8835-11eb-89de-ea1c1446b83a.png)
## The Armor of God

Ephesians 6:10-11

10 Finally, be strong in the Lord and in his mighty power. 11 Put on the full armor of God, so that you can take your stand against the devil’s schemes.

This project provides daily scripture to all of those who need to hear it. Daily verses can be selcted in any amount, and any scripture that is calling you to a deeper look today can be saved to the "My Favorites" page

## Important Credentials & Files Required:
Copy appsettings.json.example as appsettings.json in the same folder
and add your keys/secrets. These are required to access the Verse of the Day API. See example structure below:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": ""
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "Bible_API": {
    "base_url": "",
    "subscription_key_header": "Ocp-Apim-Subscription-Key\t",
    "subscription_key_header_value": ""
  },
  "AllowedHosts": "*"
}
```
## Database Connection string
Create a file (same project folder level as appsettings.json) called vod.db and this will serve as your SQL Lite database. This will give you a database connection string value of "Data Source=vod.db" and it will need to be placed as the value for "DefaultConnection" inside ConnectionStrings in appsettings.json

## Building the project
Build any .NET Core sample using the .NET Core CLI, which is installed with [the .NET Core SDK](https://www.microsoft.com/net/download). Then run
these commands from the CLI in the directory of any sproject
```console
dotnet build
```

These will install any needed dependencies a build the project


## Entity Framework Core DB Migrations
This project uses Entity Framework Core as an ORM, and requires migrations to be run on the db (vod.db file) before the application can be started. Make sure there is a DefaultConnection string in appsettings.json prior to running these commands. 

[Read Microsoft Docs for EF Core](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)

Install this package for EF Core migration commands 
```console
dotnet tool install --global dotnet-ef
```

Run this commands using the dotnet CLI:
```console
dotnet ef database update
```
Anytime a Model.cs file changes, you will need to create a new migration by running
```console
dotnet ef migrations add AddNewColumnToVerse
```

## Run the Application
To build and run Verse of the Day:

1. Go to the project folder and build to check for errors:

    ```console
    dotnet build
    ```

2. Run your project:

    ```console
    dotnet run
    ```

3. Your console should look something like this (ports may differ)
    ```console
    info: Microsoft.Hosting.Lifetime[0]
        Now listening on: https://localhost:5001
    info: Microsoft.Hosting.Lifetime[0]
        Now listening on: http://localhost:5000
    info: Microsoft.Hosting.Lifetime[0]
        Application started. Press Ctrl+C to shut down.
    info: Microsoft.Hosting.Lifetime[0]
        Hosting environment: Development
    info: Microsoft.Hosting.Lifetime[0]
        Content root path: ~/webbdm_verse_of_the_day/webbdm_verse_of_the_day
    ^Cinfo: Microsoft.Hosting.Lifetime[0]
    ```

4. Visit the above url and you should see the Verse of the Day Homepage. The app is now running successfully!
## Homepage
 ![Homepage](https://user-images.githubusercontent.com/13399339/111725456-18769180-8835-11eb-89de-ea1c1446b83a.png)
## Verses from the Verse of the Day API
![Verses](https://user-images.githubusercontent.com/13399339/111725501-2d532500-8835-11eb-865d-a38b2949984b.png)