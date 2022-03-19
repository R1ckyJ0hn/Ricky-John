using System;
class Father
{
int NumProperty;
public Father()
{
Console.WriteLine("Father class constructor invoked");
}
public Father(int nProperty)
{
NumProperty = nProperty;
Console.WriteLine("BaseClass constructor invoked");
Console.WriteLine("No of properties owned " + NumProperty);
}
}
class Child:Father
{
string property;
public Child()
{
Console.WriteLine("Child class constructor Invoked");
}
public Child(string str, int n):base(n)
{
property = str;
Console.WriteLine(property);
}
}
class impleCons
{
public static void Main()
{
Child cobj = new Child();
Child cobj1 = new Child("Villa",2);
}
}