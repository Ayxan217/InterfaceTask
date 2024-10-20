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
        static string[] Groups = new string[0];
        static int GroupCount=0;
        public int GroupId;
        public string GroupName { get; set; }
        public string[] Students = new string[0];
        int StudentCount = 0;
        int StudentId = 0;
   

        public Group(string groupName)
        {

            GroupId = ++GroupCount;
            GroupName = groupName;



            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = groupName;

        }

        
        public void AddStudent(string student)
        {
            
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            StudentCount++;
            StudentId = StudentCount;
   
        }
        public  void GetGroupInfo()
        {
            Console.WriteLine($"Group's Name: {GroupName}, attendance: {StudentCount}");

            
        }
       
        public void RemoveStudent(string student)
        {
            int index = 0;
            string[] arr = new string[Students.Length-1];
            for(int i = 0; i < Students.Length; i++)
            {
               if(student == Students[i])
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
                Console.WriteLine($"Student {student} removed.");
                StudentCount--;
            }
            else
            {
                Console.WriteLine($"Student {student} not found");
            }
        }
       
    }
}
