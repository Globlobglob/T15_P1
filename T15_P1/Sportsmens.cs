using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15_P1
{
    internal class Sportsmens
    {
        private string name;
        public string Name { get => name; set => name = value; }

        private string surname;
        public string Surname { get => surname; set => surname = value; }

        private string midlname;
        public string Midlname { get => midlname; set => midlname = value; }

        private int weight;

        public int Weight { get => weight ; set =>weight=value; }

        private static int countweight;
        private static int count;

        public Sportsmens()
        {
            count = 0;
            countweight = 0;
        }

        public  Sportsmens(string name,string surname,string midlname,int weight)
        {
            this.name = name; this.surname = surname; this.midlname = midlname; this.weight = weight;
            if (weight > 70) { countweight++; }
            count++;
        }

        public void Print()
        {
            Console.WriteLine($"Name-{Name}\nSurname-{Surname}\nMiddlename-{Midlname}\nWeight-{countweight}");
        }
      
    }
}
