using InterfaceTask.Models;

namespace InterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Student student = new("Ayxan", "Mammadli");
            //Student student2 = new("Ayxan", "Mammadli");
            //Student student3 = new("Ayxan", "Mammadli");
            //Student student4 = new("Ayxan", "Mammadli");
            //Student student5 = new("Ayxan", "Mammadli");
            //Student student6 = new("Ayxan", "Mammadli");
            //Student student7 = new("Ayxan", "Mammadli");
            //Console.WriteLine(student7.Id);

            Group group = new("Bp-217");
            group.AddStudent("ayxan memmedli");
            group.AddStudent("ayxan memmedli");


            group.GetGroupInfo();




        }
    }
}
