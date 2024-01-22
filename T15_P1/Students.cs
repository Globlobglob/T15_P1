using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T15_P1
{
    internal class Students
    {
        private string name;
        public string Name { get => name; set => name = value; }
        
        private string surname;
        public string Surname { get => surname; set => surname = value; }

        private string midlname;
        public string Midlname { get => midlname; set => midlname = value; }

        private  int gender;
        public int Gender { get => gender; set => gender = value; }

        private static int malecount;
        private static int femalecount;
        private static int count;
        /// <summary>
        /// Static constructor with no param
        /// </summary>
        public Students() { }

        static Students()
        {
            count = 0;
            malecount= 0;
            femalecount = 0;

        }
        /// <summary>
        /// Static counstruct with initialized field and genderfilter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="midlname"></param>
        /// <param name="gender"></param>
        public Students(string name,string surname,string midlname,int gender) 
        {
            this.name = name;this.surname = surname;this.midlname = midlname;this.gender = gender;
            if (gender == 1) { malecount++; }else{ femalecount++; }
            count++;
        }

        public void Print()
        {
            Console.WriteLine($"Name-{Name}\nSurname-{Surname}\nMiddlename-{Midlname}\n");
           
        }
        public static void GetGender()
        {
            Console.WriteLine($"male-{malecount}\nfemale-{femalecount}\nCount-{count}");
        }

    }
}
