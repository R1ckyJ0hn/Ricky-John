using System;
interface membership
{
void Silver();
void Gold();
void Platinum();
}
class team:membership
{
public void Silver()
{
Console.WriteLine("Silver \n * 3 days aacomadation at resort");
}
public void Gold()
{
Console.WriteLine("Gold \n * 5 days acomadation at resort and 2 dinner on the house  ");
}
public void Platinum()
{
Console.WriteLine("Gold \n * 7 days acomadation at resort and 5 dinner on the house  ");
}
}
class id
{
public static void Main()
{
team obj=new team();
obj.Silver();
obj.Gold();
obj.Platinum();
}
}