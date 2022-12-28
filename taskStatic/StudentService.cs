using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskStatic
{
    internal class StudentService : IStudentService
    {
        public void Create(string name, string surname, Group studentGroup)
        {
            Student student = new Student();
            student.Name = name;
            student.Surname = surname;
            Array.Resize(ref studentGroup.Students, studentGroup.Students.Length + 1);
            studentGroup.Students[studentGroup.Students.Length-1] = $"{name} {surname}";
        }

     

        public void Delete(int id, Group studentGroup)
        {
            if(id >=0 && id<= studentGroup.Students.Length-1)
            {
                studentGroup.Students = studentGroup.Students.Where(val => val != studentGroup.Students[id]).ToArray();
            }
            else
            {
                Console.WriteLine("Bu id-de telebe yoxdur ");
            }
        }

        public void Edit(int id, string name, string surname, Group studentGroup)
        {
            if (id >= 0 && id <= studentGroup.Students.Length - 1)
            {
                studentGroup.Students[id] = $"{name} {surname}";
            }
            else
            {
                Console.WriteLine("Bu id-de telebe yoxdur");
            }
            }

        public void GetAll(Group studentGroup)
        {
            foreach(string fullName in studentGroup.Students)
            {
                Console.WriteLine(fullName);
            }
        }

        public void GetById(int id, Group studentGroup)
        {
            Console.WriteLine(studentGroup.Students[id]);
        }
    }
}
