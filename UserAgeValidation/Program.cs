// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please, select your gender (m/f)!");

char UserGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your last name:");
string UserLastName = Console.ReadLine();

if (UserGender == 'm' )
{
    Console.WriteLine($"Welcome, Mr.{UserLastName}!");
}
else if(UserGender == 'f')
{
    Console.WriteLine($"Welcome, Miss. {UserLastName}!");
} 
else
{
    Console.WriteLine("Welcome");
}
