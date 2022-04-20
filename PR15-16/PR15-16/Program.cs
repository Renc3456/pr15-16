using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR15_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа 15-16");
            Console.WriteLine("Выполнили Стародубцев Маским");
            Console.WriteLine("Вариант 2");
            Console.WriteLine();

            StreamReader sr = new StreamReader(@"input.txt", Encoding.UTF8);
            STUDENT student = new STUDENT();
            student.InputFromFile(sr);
            if (student.Math == 3 || student.Math == 4)
            {
                Console.WriteLine(student.PrintInfo());
                student.Save();
            }

            else if (student.History == 3 || student.History == 4)
            {
                Console.WriteLine(student.PrintInfo());
                student.Save();
            }

            else if (student.Physics == 3 || student.Physics == 4)
            {
                Console.WriteLine(student.PrintInfo());
                student.Save();
            }

            else if (student.Obzh == 3 || student.Obzh == 4)
            {
                Console.WriteLine(student.PrintInfo());
                student.Save();
            }

            else if (student.French == 3 || student.French == 4)
            {
                Console.WriteLine(student.PrintInfo());
                student.Save();
            }

            else
            {
                Console.WriteLine("нет студента с оценкой 3 или 4");
            }



            Console.ReadKey();
        }
    }
}
