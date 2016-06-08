# InternWarz
A website that organizes casual and competive events for interns in the Seattle area

Steps to install:

1) install the [.NET Core CLI Tools](https://github.com/dotnet/cli)
2) open a CMD prompt
3) navigate to /{project-root}/src/InternWarz
4) :
dotnet restore
5) Get the below credentials from repo owner/contributors:
dotnet user-secrets set FacebookAppId {secret-app-id}
dotnet user-secrets set FacebookAppSecret {secret-app-secret}
6) run in Visual Studio 2015

Reminder: to build with Facebook integration, please contact Terrence Anderson for the App Id and App Secret commands