﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class dessert
    {
        public static void Main()
        {

            FileStream fs = new FileStream(@"D:\Training\Day 11\Lesson\ Dessert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter bw = new StreamWriter(fs);
            List<string> str = new List<String>();
            str.Add("Coconut Truffle");
            str.Add("Rasamalai");
            str.Add("Caramel Custard");
            str.Add("Bread Halwa");
            str.Add("Lichi Mousse");
            foreach (string d in str)
            {
                bw.Write("\n" + d);
            }
            bw.Flush();
            bw.Close();
            fs.Close();
            FileStream fs1 = new FileStream(@"D:\Training\Day 11\Lesson\ Dessert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            String s = sr.ReadToEnd();
            sr.Close();
            fs1.Close();
            Console.WriteLine(s);
            FileInfo fi = new FileInfo(@"D:\Training\Day 11\Lesson\ Dessert.txt");
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.Read();
        }
    }
}
