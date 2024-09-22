// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Please enter your age");

string userAGE = Console.ReadLine();
int userAGENum = 0;
bool isAGENumber = Int32.TryParse(userAGE, out userAGENum);

//int userAGE = Int32.Parse(Console.ReadLine());

if (isAGENumber == true)
{
    if (userAGENum >= 13)
    {
        Console.WriteLine("Welcome back");
    }
    else
    {
        Console.WriteLine("Sorry you are too young3");
    }
}
else Console.WriteLine("Could not read your age srry");
