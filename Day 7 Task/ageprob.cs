using System;
class age
{
public static void Main()
{
string name;
int age;
Console.WriteLine("Please enter the name");
name=Console.ReadLine();

Console.WriteLine("Please enter the Age");
age=Convert.ToInt32(Console.ReadLine());
int i=1;

while(i<=age)
{
Console.WriteLine(name);
i++;
}
}
}