using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //int a;
            //Console.WriteLine("Enter Number of students =");
            //a = int.Parse(Console.ReadLine());
            //Students[] students = new Students[a];
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine("Name:");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Surname:");
            //    string surname = Console.ReadLine();
            //    Console.WriteLine("Middlename:");
            //    string midlname = Console.ReadLine();
            //    Console.WriteLine("Gender (1 for male, 2 for female):");
            //    int gender = int.Parse(Console.ReadLine());
            //    students[i] = new Students(name, surname, midlname, gender);

            //    students[i].Print();
            //}
            //Students.GetGender();

            int b;
            Console.WriteLine("Enter Number of students =");
            b = int.Parse(Console.ReadLine());
            Sportsmens[] sportsmen= new Sportsmens[b];
            for (int i = 0; i < sportsmen.Length; i++)
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("Middlename:");
                string midlname = Console.ReadLine();
                Console.WriteLine("Weights");
                int weight = int.Parse(Console.ReadLine());
                sportsmen[i] = new Sportsmens(name, surname, midlname, weight);

                sportsmen[i].Print();

                Console.ReadLine();
        }   }
    }
}
