using InterfaceTask.Models;

namespace InterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Student student = new("Ayxan", "Mammadli");
            Student student2 = new("nicat", "quliyev");
            Student student3 = new("emin", "memmedov");
            Student student4 = new("vusal", "agazade");
            Student student5 = new("gence", "mehreliyev");
            Student student6 = new("merazeli", "penahov");

            Student.Captalize("aYXan","mEmmedLi");

            Group group = new("Bp-217");
            Group group2 = new("Fe-25");
            Group group3 = new("Fe-2515");
            Group.AddGroup(group);
            Group.AddGroup(group2);
            Group.AddGroup(group3);
            Group.RemoveGroup(2);


            Group.ShowAllGroups();
            group2.AddStudent(student4);
            group2.AddStudent(student5);
            group2.AddStudent(student6);
            group2.ShowStudents();
            group.AddStudent(student);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.RemoveStudent(2);
            group.ShowStudents();
            group.GetGroupInfo();
            group2.GetGroupInfo();
            





        }
    }
}
