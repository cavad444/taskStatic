using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskStatic
{
    internal interface IStudentService
    {
        public void Create(string name, string surname);
        public void Delete(int id);
        public void Edit(int id,string name,string surname);
        public void GetAll();
        public void GetById(int id);
    }
}
