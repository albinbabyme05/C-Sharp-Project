
using Student_Info_Manager;

namespace Student_Info_Manager
{
    class Program
    {

        static void Main(string[] args)
        {
            //create an instance of the class
            Student s1 = new Student("Albin", 28, 60);

            s1.DisplayDetails();

            s1.setMark(50);
            s1.DisplayDetails();

            s1.setAge(23);
            s1.DisplayDetails();



            


        }
    }
}

