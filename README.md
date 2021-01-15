# Pierre's Patisserie

#### By Cory Nordenbrock
##### 1/15/21

## _What_ does it do?

* This app allows a user to create an account, login/logoff, and implement CRUD functionalities to discover the delicious flavors and treats from a fake patisserie.

## _Why_ does it do?

* This project was prompted by the wonderful people at [Epicodus](https://www.epicodus.com/) as an exercise in the architectural style of Model-View-Controller development, persisting data with an SQL database using Entity, and user authentication/authorization using Identity.

## Setup Instructions

   _**Note**: [.NET Core](https://dotnet.microsoft.com/download) must be installed for the following instructions (v 2.2 for current source code, later versions may be used by editing the ` <TargetFramework> ` element in PierresPatisserie.Solution.csproj to reflect the correct version)._

* To clone and build program:

1. Clone this repository: ` git clone https://github.com/cordenbrock/PierresPatisserie.Solution `
2. Navigate to this specific directory from project folder root: ` cd factory/PierresPatisserie `
3. From this directory in your terminal, pass a ` dotnet restore ` command followed by a ` dotnet build ` command. This will install all the necessary dependencies and build the app.

* To setup database:

4. If no Migrations directory exists, pass the command ` dotnet ef migrations add Initial ` in your terminal from the root directory to generate a new Migrations directory that Entity will use to recreate the database schema.
5. Use ` dotnet ef database update ` command to scaffold database.

* To run program:

6. Pass the command ` dotnet run ` in your terminal from the root directory.
7. From your web browser, go to http://localhost:5000 to use the app.


## Built with/Tools used

* _C#_
* _ASP.NET Core Razor MVC_
* _MySQL_
* _Entity_
* _Identity_

### Known Bugs/Future Improvements

* No known bugs

### Legal

MIT License, (c) 2020 Cory Nordenbrock