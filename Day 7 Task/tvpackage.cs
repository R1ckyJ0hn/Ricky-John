using System;
class Tvchannel
{
public static void Main()
{
int n;
Console.WriteLine("Please select your package:");
Console.WriteLine("1.Type 1 for package A\n *Children's hub \n *South special \n *Movies");
Console.WriteLine("2.Type 2 for package B\n *News \n *Sports \n *Movies \n *Regional-2");
Console.WriteLine("3.Type 3 for package C \n *National \n *Discovery");
n=Convert.ToInt32(Console.ReadLine());
switch(n)
{
case 1 :Console.WriteLine("Your package cost Rs.250");
break;
case 2 :Console.WriteLine("Your package cost Rs.450");
break;
case 3 :Console.WriteLine("Your package cost Rs.350");
break;
default :Console.WriteLine("You did not choose a valid option");
break;
}
}
}