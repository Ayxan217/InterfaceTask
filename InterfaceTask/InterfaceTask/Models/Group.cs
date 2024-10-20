using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceTask.Models
{
    internal class Group
    {
        static Group[] Groups = new Group[0];
        static int GroupCount = 0;
        static int GroupId=0;
        public string GroupName { get; set; }
        public Student[] Students = new Student[0];
        int StudentCount = 0;
        int StudentId = 0;


        public Group(string groupName)
        {

            GroupId = ++GroupCount;
            GroupName = groupName;





        }


        public void AddStudent(Student student)
        {

            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            StudentCount++;
            StudentId = StudentCount;

        }
        public void GetGroupInfo()
        {
            Console.WriteLine($"Group's Name: {GroupName}, attendance: {StudentCount}");


        }

        public void RemoveStudent(int id)
        {
            int index = 0;
            Student[] arr = new Student[Students.Length - 1];
            for (int i = 0; i < Students.Length; i++)
            {
                if (id == i)
                {
                    if (index < arr.Length)
                    {
                        arr[index] = Students[i];
                        index++;

                    }
                }
            }
            if (index == arr.Length)
            {
                Students = arr;
                Console.WriteLine($" {id} th Student removed.");
                StudentCount--;
            }
            else
            {
                Console.WriteLine($"Student not found");
            }
        }
        public void ShowStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i].Name + " "+ Students[i].Surname);
            }
        }
        public static void AddGroup(Group groupName)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            GroupId = ++GroupCount;
            Groups[Groups.Length - 1] = groupName;
            Console.WriteLine(" new group added");
        }

        public static void ShowAllGroups()
        {
            foreach (var group in Groups)
            {
                Console.WriteLine(group.GroupName);
            }
        }
        public static void RemoveGroup(int groupId)
        {
            int index = 0;
            Group[] arr = new Group[Groups.Length - 1];
            for (int i = 0; i < Groups.Length; i++)
            {
                if (groupId == i)
                {
                    if (index < arr.Length)
                    {
                        arr[index] = Groups[i];
                        index++;

                    }
                }
            }
            if (index == arr.Length)
            {
                Groups = arr;
                Console.WriteLine($" {groupId} th Student removed.");
                GroupCount--;
            }
            else
            {
                Console.WriteLine($"Group not found");
            }

        }

      
    }
}
