using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace day12
{

    [Serializable]
    class Employeede
    {

        public string name = "Sid the great";
        public int age = 25;
        public string Empid = "ABC$321";
        public string gender = "Male";

    }
    class newmeth
    {
        public void SeretoFile()
        {
            Employeede sobj = new Employeede();
            FileStream fs = new FileStream("Empdets.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fs, sobj);
            fs.Close();
        }
        public void Dserial()
        {
            FileStream fs = new FileStream("Empdets.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            Employeede stu = (Employeede) f.Deserialize(fs);
            Console.WriteLine(stu.name);
            Console.WriteLine(stu.age);
            Console.WriteLine(stu.gender);
            Console.WriteLine(stu.Empid);



        }

        public static void Main()
        {
            newmeth lobj = new newmeth();
            lobj.SeretoFile();
            lobj.Dserial();
            Console.ReadLine();

        }
    }
}
