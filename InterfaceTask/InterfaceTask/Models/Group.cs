using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

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
            GroupCount++;
            GroupId = GroupCount;
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
            int j = 0;
            Student[] newArr = new Student[Students.Length - 1];
            
            for (int i = 0; i < Students.Length; i++)
            {
               
                if (i != id)
                {
                    if (j < newArr.Length)
                    {
                        newArr[j] = Students[i];
                        j++;

                    }
                }
               


            }
            Students = newArr;
            StudentCount--;
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
            {
               
                int j = 0;
                Group[] newArr = new Group[Groups.Length - 1];

                for (int i = 0; i < Groups.Length; i++)
                {
                
                    if (i != groupId)
                    {
                        if (j < newArr.Length)
                        {
                            newArr[j] = Groups[i];
                            j++;
                        }
                    }
                   

                }
               

                Groups = newArr;
                GroupCount--;
            }


        }


    }
}
