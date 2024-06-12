## Overview
Console Chat application with keyboard navigation using .NET 6.0, Entity Framework core 6.0.12 and PostgreSQL database.
Features Group chats and private chats for all users. Users can join one of the created group chats aswell as start a private chat with another user.
Admin users have a user managment menu from which they can delete the users, change their email or promote to admin. Every user has a Settings menu in which they can change they email or password.

## Setup
  In root directory go to ```App.config``` file and change the user and password for your local postgres database. If you dont have postgres setup on your machine then install and setup pgAdmin.
### Visual Studio
  1. In package manager console choose ```ChatApp.Data``` folder and run ```Update-Database``` to run existing migrations.
  2. Build project and run it.
### VS code
  1. In terminal, position to ```ChatApp.Data``` folder and run ```dotnet ef database update```
  2. In root directory run ```dotnet run``` to start the App.



