using System;
class plist
{
public static void Main()
{
string [][] pcategory= new string [3][];
pcategory[0]= new string[]{"hide and seek","borbon","good day","milk bikies"};
pcategory[1]= new string[]{"dairy milk","silk","5-star","perk","munch"};
pcategory[2]=new string[] {"Pepsi","7up","Coke","sprite","mountain dew","Fanta"};
for(int i=0;i<pcategory.Length;i++)
{	
	for (int j=0;j<pcategory[i].Length;j++)
	Console.Write(pcategory[i][j] + "\t");
Console.WriteLine();
}	
}
}