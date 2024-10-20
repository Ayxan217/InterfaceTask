using System;
using System.Collections.Generic;
using System.Linq;
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
        public void GetId()
        {
            Console.WriteLine(StudentId);
        }
       
    }
}
