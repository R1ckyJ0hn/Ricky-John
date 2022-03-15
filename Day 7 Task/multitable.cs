using System;
class multitable
{
public static void Main()
{
int num,n;
Console.WriteLine("Enter a Number:");
num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of multipicand to generate the table ");
n=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
Console.WriteLine("{0}*{1}={2}",num,i,2num*i);
}
}
}