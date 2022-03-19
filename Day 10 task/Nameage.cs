using System;
class ename
{
int age;
public ename(int age)
{
this.age = age ;
Console.WriteLine("The age is "+age); 
}
string name;
public ename(string name)
{
this.name = name ;
Console.WriteLine("the name is "+name) ;
}
public static void Main()
{
{
ename obj=new ename("Ricky");
ename obj2=new ename(22);
}
}
}
