﻿using InterfaceTask.Models;

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
         
            

            Group group = new("Bp-217");
            Group group2 = new("Fe-25");
            Group group3 = new("Fe-2515");
            Group.AddGroup(group);
            Group.AddGroup(group2);
            Group.AddGroup(group3);
            Group.RemoveGroup(1);

            Group.ShowAllGroups();
            group.AddStudent(student);
            group.AddStudent(student5);
            group.AddStudent(student4);
            group.RemoveStudent(1);
            group.ShowStudents();
            group.GetGroupInfo();






        }
    }
}
