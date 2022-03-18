using System;
abstract class arith
{
public abstract void calc(int n1,int n2);

}
class add:arith
{
public  override void calc(int n1,int n2) 
{

Console.WriteLine("the sum is {0}",n1+n2);
}
}
class sub:arith
{
public  override void calc(int n1,int n2)
{

Console.WriteLine("the diff is {0}",n1-n2);
}
}
class mul:arith
{
public  override void calc(int n1,int n2) 
{
Console.WriteLine("the prod is {0}",n1*n2);
}
}
class div:arith
{
public  override void calc(int n1,int n2) 
{
Console.WriteLine("the rem is {0}",n1/n2);
}
}
class Calcula
{
public static void Main()
{
int n1=30,n2=10;
add aobj= new add();
aobj.calc(n1,n2);

sub sobj= new sub();
sobj.calc(n1,n2);

mul mobj= new mul();
mobj.calc(n1,n2);

div dobj= new div();
dobj.calc(n1,n2);


}
}