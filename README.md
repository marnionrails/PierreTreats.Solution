# Pierre's Treats

#### By _**Marni Sucher**_

#### _An application for Pierre to track his treats and flavors at his bakery._

## Technologies Used

* C#
* .NET 5.0
* dotnet
* MySql/Workbench

## Description

An application for Pierre to track the treats at his bakery according to their flavor (e.g. sweet, savory, spicy) and vice versa through a many-to-many relationship:
Logged in users will be able to:
* Add a treat to the system including name and flavor(s).
* Add a flavor to the system and add treats to that flavor
* Update and delete treats and the flavors associated with it
* Update and delete flavors and the treats associated with it

## Setup/Installation Requirements

* Make sure you have MySql Workbench installed on your computer.
* Make sure to have dotnet-ef installed too.<br>
<em>This project uses <code>dotnet-ef --version 3.0.0</code> which I have globally installed but you can install it however you want. 
* Using either clone or the download link, download this repo to your machine: https://github.com/marnionrails/PierreTreats.Solution
* Open the project in VScode or your terminal/IDE of choice.
* Create a <code>appsettings.json</code> file in the root directory of the project folder. And add the following code replacing anything in square brackets with the information it represents specific to the project database:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME-HERE];uid=[USER-ID-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

```

Example of complete appsettings.json:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=root;pwd=MySuperStrongPassword;"
  }
}

```
* Make sure to run your mysql server and open MySql workbench.
* Open MySql Workbench and login to your server.
* Now using your IDE, navigate into the PierreTreats.Solution/PierreTreats folder and use the command <code>dotnet ef database update</code> to update the database in MySql workbench.
* Remain in the PierreTreats.Solution/PierreTreats/ folder and use the command <code>dotnet run</code> to launch the program. 
* The site should be available at the server address you used in the <code>appsettings.json</code> folder.


## Known Bugs

* _No known bugs_

## Contact Me

Let me know if you run into any issues or have questions, ideas or concerns:  
suchermarni@gmail.com

## License

_MIT_

Copyright (c) _2022_ _Marni Sucher_