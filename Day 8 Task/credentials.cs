using System;
class checkncom
{
public void Compare(string a,string b)
{
string id="rickyjohn27@gmail.com";
string pass="dem.password";
if (a=id && b=pass)
{
Console.WriteLine("userId and Password is correct");
}
else
Console.WriteLine("userId and Password is invalid");
}
public void Compare(string a,int b)
{
string memid="abcd1234";
 int pin= 2112;
if(a= memid && b=pin)
	{
	Console.WriteLine("Membership id and Pin is correct");
	}
else
Console.WriteLine("Membership id or Pin is invalid");

}
public static void Main()
{
checkncom obj =new checkncom();
Console.WriteLine("Press 1 to login with user ID and password \n Press 2 to login with Membership ID and pin");	
int n = Convert.ToInt32(Console.ReadLine());
switch(n)
{
case 1:
{
Console.WriteLine("Please Enter your Credentials");
string n1=Console.ReadLine();
string n2=Console.ReadLine();
obj.Compare(n1,n2);
break;
}
case 2:
{
Console.WriteLine("Please Enter your Credentials");
string n1=Console.ReadLine();
int n2=Convert.ToInt32(Console.ReadLine());
obj.Compare(n1,n2);
break;
}
default:Console.WriteLine("Please choose a valid option");
break;
}
}
}