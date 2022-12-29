using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskStatic
{
    internal interface IStudentService
    {
        public void Create(string name, string surname, double avarage,Group studentGroup);
        public void Delete(int id,Group studentGroup);
        public void Edit(int id,string name,string surname,double avarage, Group studentGroup);
        public void GetAll(Group studentGroup);
        public void GetById(int id, Group studentGroup);
    }
}
