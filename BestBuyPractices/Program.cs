using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using BestBuyPractices;
using System.Collections.Generic;
//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);

var dap = new DapperDepartmentRepository(conn);
var departments = dap.GetAllDepartments();
Console.WriteLine("Select a department");
Console.WriteLine("Please press enter . . .");
Console.ReadLine();


Console.WriteLine("Do you want to add a Department?");
string userInput = Console.ReadLine();

if (userInput.ToLower() == "yes")
{
    Console.WriteLine("what is the name of your new Department??");
    userInput = Console.ReadLine();

    dap.InsertDeparments(userInput);
    Print(dap.GetAllDepartments());
}
Console.WriteLine("have a great day.");

 static void Print(IEnumerable<Departments> daps)
{
    foreach (var dap  in daps)
    {
        Console.WriteLine($"ID: {dap.DepartmentID} \n Name:{dap.Name}");
    }
}