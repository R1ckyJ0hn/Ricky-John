using System;
class Covidtest
{
public static void Main()
{
string ans;
Console.WriteLine("Do you have any travel history ?");
ans =Console.ReadLine();
if(ans=="yes")
{
Console.WriteLine("Do you have Temprature ?");
ans =Console.ReadLine();
if(ans=="yes")
{
Console.WriteLine("Do you have cough/sneeze");
ans =Console.ReadLine();
if(ans=="yes")
{
Console.WriteLine("please take a swab test");
}
else
Console.WriteLine("Quarantine with fever medicine");
}
else
Console.WriteLine("Home-Quarantine For 28 days");
}
else
Console.WriteLine("Safe to go home");











}
}