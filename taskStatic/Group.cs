using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskStatic
{
    internal class Group : Student
    {
        private static int _id;
        private string _name;
        public string[] Students = new string[_id];

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }


       

    }
}
