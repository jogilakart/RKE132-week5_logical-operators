﻿string userPIN, userName, password;
Console.WriteLine("Enter PIN:");
userPIN = Console.ReadLine();
Console.WriteLine("Enter your username:");
userName = Console.ReadLine();
Console.WriteLine("Enter your password:");
password = Console.ReadLine();

if (userPIN == "1234")
{
    if(userName == "admin1" && password == "admin1234")
    {
    Console.WriteLine("Welcome!");
    }
    else
    {
    Console.WriteLine("Invalid login credentials.");
    }
}
else
{
    Console.WriteLine("Invalid PIN");
}
