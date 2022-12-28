using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskStatic
{
    internal class StudentService : IStudentService
    {
        public string fullName;
       
        public void Create(string name, string surname)
        {
            fullName = $"{name} {surname}";
            Student student = new Student();
            student.Name = name;
            student.Surname = surname;
            Array.Resize(ref Group.Students, Group.Students.Length + 1);
            Group.Students[Group.Students.Length-1] = fullName;
        }

        public void Delete(int id)
        {
            if(id >=0 && id<=Group.Students.Length-1)
            {
                Group.Students = Group.Students.Where(val => val != Group.Students[id]).ToArray();
            }
            else
            {
                Console.WriteLine("Bu id-de telebe yoxdur ");
            }
        }

        public void Edit(int id, string name, string surname)
        {
            if (id >= 0 && id <= Group.Students.Length - 1)
            {
                Group.Students[id] = $"{name} {surname}";
            }
            else
            {
                Console.WriteLine("Bu id-de telebe yoxdur");
            }
            }

        public void GetAll()
        {
            foreach(string fullName in Group.Students)
            {
                Console.WriteLine(fullName);
            }
        }

        public void GetById(int id)
        {
            Console.WriteLine(Group.Students[id]);
        }
    }
}
