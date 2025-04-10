using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Info_Manager
{
    public class Student
    {
        private string Name { get; set; }
        private int Age;
        private int Mark;

        public Student(string name, int age, int mark)
        {
            Name = name;
            Age = age;
            Mark = mark;
        }

        public void setAge(int age)
        {
            if (age > 0)
            {
               Age = age;
            }
            else
            {
                Console.WriteLine("invalid age");
            }
            
        }
        public int getAge()
        {
            return Age;
        }

        public void setMark(int mark)
        {
            if(mark >0 && mark <= 100)
            {
                Mark = mark;
            }
            else
            {
                Console.WriteLine("INvalid mark");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student Name: "+Name);
            Console.WriteLine($"{Name} is {Age} years old");
            Console.WriteLine($"Mark obtained by {Name} : {Mark}");
        }
    }
}
