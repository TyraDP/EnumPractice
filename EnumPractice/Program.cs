using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyFileClass file1 = new MyFileClass("picture.txt", @"C:\users\tyrad\Documents", 
                Rights.READABLE | Rights.WRITABLE,
                null);

            Console.WriteLine(file1.FileRights);
            //Create an enum use or |
            //To Check an enum use and &
            //Make the lab public
        }
    }
}
