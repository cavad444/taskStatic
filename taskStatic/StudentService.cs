using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskStatic
{
    internal class StudentService : IStudentService
    {
        public void Create(string name, string surname, double avarage, Group studentGroup)
        {
            Student student = new Student
            {
                Name = name,
                Surname = surname,
                Avarage = avarage
            };
            Array.Resize(ref studentGroup.Students, studentGroup.Students.Length + 1);
            studentGroup.Students[studentGroup.Students.Length - 1] = student;
        }



        public void Delete(int id, Group studentGroup)
        {
            if (id >= 0 && id <= studentGroup.Students.Length - 1)
            {
                studentGroup.Students = studentGroup.Students.Where(val => val != studentGroup.Students[id]).ToArray();
            }
            else
            {
                Console.WriteLine("Bu id-de telebe yoxdur ");
            }
        }

        public void Edit(int id, string name, string surname,double avarage, Group studentGroup)
        {
            if (id >= 0 && id <= studentGroup.Students.Length - 1)
            {
                studentGroup.Students[id].Name = name;
                studentGroup.Students[id].Surname= surname;
                studentGroup.Students[id].Avarage= avarage;
            }
            else
            {
                Console.WriteLine("Bu id-de telebe yoxdur");
            }
        }

        public void GetAll(Group studentGroup)
        {
            for (int i = 0; i < studentGroup.Students.Length; i++)
            {
                Console.WriteLine($"{studentGroup.Students[i].Name} {studentGroup.Students[i].Surname} {studentGroup.Students[i].Avarage}");
            }
        }

        public void GetById(int id, Group studentGroup)
        {
            try
            {
                Console.WriteLine($"{studentGroup.Students[id].Name} {studentGroup.Students[id].Surname} {studentGroup.Students[id].Avarage}");
            }
            catch (Exception e)
            {

                Console.WriteLine("Bu index-li telebe yoxdur");
            }

        }
    }
}
