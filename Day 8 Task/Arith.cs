using System;
class addsub1
{
public void addsub(int x,int y)
{
int sum= x + y;
int diff= x - y;
Console.WriteLine("the sum is "+ sum +" and the diff is "+ diff);
}
}
class muldiv1:addsub1
{
public void muldiv(int x,int y)
{
int prod= x * y;
int rem = x / y;
Console.WriteLine("the product is "+ prod +" the remainder "+ rem);
}
}
class Arithmet
{
public static void Main()
{
muldiv1 obj= new muldiv1();
obj.muldiv(20,10);
obj.addsub(30,10);
}
}