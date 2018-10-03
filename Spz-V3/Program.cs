using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb1
{
   
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Student student1 = new Student("Alex", 3, "MT321");
                student1.FillMarks();

                Student student2 = new Student("Valera", 1, "ZP131");
                student2.FillMarks();
                student2[Subjects.Databases] = 75;
                student2[Subjects.English] = 60;
                student2[Subjects.Mathematics] = 60;
                student2[Subjects.Programming] = 100;

                Console.WriteLine(student1);
                Console.WriteLine(student2);

                Console.WriteLine(new string('-', 35));

                foreach (var item in student1.EqualsMarks(student2))
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
