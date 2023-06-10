using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_08_lab.BL;

namespace Week_08_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // t1();
            // t2();
            truck t = new truck();
            horsePipe h = new horsePipe();
            t.setPipe(h);
        }
        public static void t1()
        {
            dayScholar s = new dayScholar();
            s.name = "Bilal";
            s.busNo = 19;
            Console.WriteLine(s.name + " Is Allocated bus " + s.busNo);
            Console.ReadKey();
        }
        public static void t2()
        {
            hostelide s = new hostelide();
            s.name = "Abdullah";
            s.roomNo = 126;
            Console.WriteLine(s.name + " Is Allocated Room " + s.roomNo);
            Console.ReadKey();
        }
      


    }
}
