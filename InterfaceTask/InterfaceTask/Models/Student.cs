using InterfaceTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterfaceTask.Models
{
    internal class Student:ICodeAcademy
    {
        static int Count = 0;
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }

        public Student(string name, string surname)
        {
            
            if (CheckName(name, surname))
            {
                Count++;
                Id = Count;
                Name = name;
                Surname = surname;

                Console.WriteLine(GenerateEmail());
            }
            else
            {
                
                Console.WriteLine("Student does not created. please enter valid name and surname");
            }
        }


        public static void Captalize(string name, string surname)
        {
             name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            surname = char.ToUpper(surname[0]) + surname.Substring(1).ToLower();
            Console.WriteLine($"{name} {surname}");
        }
        public static bool CheckName(string name, string surname)
        {
            string pattern =  @"^[a-zA-ZğüşöçəƏİĞÜŞÖÇ]{3,25}$";
            if (Regex.IsMatch(name, pattern) && Regex.IsMatch(surname, pattern))
            {
                
                return true;
            }
            else
            {
               
                return false;
            }
        }
     

        public string GenerateEmail()
        {
            string domain = "@code.edu.az";
            CodeEmail = String.Concat(Name, ".", Surname, Id).ToLower() + domain;
            return CodeEmail;
        }

       
    }
}
