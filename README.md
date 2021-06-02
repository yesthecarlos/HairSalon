# _Hair Salon_

#### _.NET 5 MVC Salon Overview Program using EF Core 5 and MySQL_

#### By _**Carlos Mendez**_

## Technologies Used

* C#
* .NET 5
* EF Core 5
* MySQL


## Description

_This project uses C#, .NET 5, EF Core 5, MySQL and the MVC pattern to create an overr a a hypothetical factory's machines.  The app welcomes the user and allows them view and add stylists and clients and allows the user to assign clients to stylists. A database schema file is included in the root directory of the project. A diagram of the schema is included below._
  
  <img src="https://github.com/yesthecarlos/HairSalon/blob/main/schema.png?raw=true" alt="carlos_mendez_schema" width="600"/>

## Setup and Use

### Prerequisites
* [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)
* A web browser to run and interact with the web app.

### Installation
1. Clone the repository: `$ git clone https://github.com/yesthecarlos/HairSalon`
2. Navigate to the `HairSalon/` directory on your computer
3. Open with your preferred text editor to view the code base
4. Create a file named appsettings.json and save it in the project's root directory. It should contain the following code:
```c#
{
  "ConnectionStrings": 
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=carlos_mendez;uid=[user];pwd=[password];"
  }
}
```
4. To run the web app:
    * Navigate to `HairSalon/` in your command line
    * Run the command `dotnet restore` to restore the dependencies that are listed in the .csproj
    * Run the commmand `dotnet build` to build the project and its dependencies into a set of binaries
    * Create a datbase using SQL via MySQL:
      -In the Navigator > Administration window, select Data Import.Restore
      -In _Import Options_ select _Import from Self-Contained File._
      -Navigate to _carlos\_mendez.sql_ in the main directory
      -Under _Default Scheme to be Imported To_, select the _New_ button
      -Enter the name of the database _(carlos\_mendez.sql)_ and click OK
      -Click _Start Import_
    * Run the command `dotnet run` to run the project
    * Finally, open the project in your web browser, using the specified address (default is localhost:5000)
 
## Feature Plans

_Tracking of additional properties (such as appointments, specialites, etc.), and the addition of styling will make the project pop._

## License

_Copyright 2021 Carlos Mendez_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

_

## Contact Information

_carlosmendez86@gmail.com_