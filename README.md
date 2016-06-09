# InternWarz
A website that organizes casual and competive events for interns in the Seattle area

Project Goal: allow people to choose an event (Paintball, Ultimate Frisbee, Dota 2, etc.) and a company to play for (Microsoft, Amazon, Boeing, etc.) and then have an auto-generated tournament bracket to easily organize, plan and distribute

First deliverable: create a Paintball bracket containing the tech companies in Seattle (MS, Amaz, Goog, etc) that can be manually managed.

Steps to install:

* 1) install the [.NET Core CLI Tools](https://github.com/dotnet/cli)

* 2) open a CMD prompt

* 3) navigate to /{project-root}/src/InternWarz

* 4) enter:

       ```dotnet restore```

* 5) Get the below credentials from repo owner/contributors and then enter these commands in the window:
 
 ```dotnet user-secrets set FacebookAppId {secret-app-id}  
    dotnet user-secrets set FacebookAppSecret {secret-app-secret}
```

* 6) run in Visual Studio 2015

*Reminder*: in order to build with Facebook integration, please contact Terrence Anderson for the App Id and App Secret commands