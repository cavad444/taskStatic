using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskStatic
{
    internal class Student:StudentService
    {
        private static int _id = 1;
        private string _name;
        private string _surname;
        private double _avarage;
        public int id;
        public int Id { get; set; }
        public string Name {
            get { 
                return _name;
            }
            set
            {
                if(!string.IsNullOrEmpty(value) && value.Length>=3 && value.Length <= 15)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Telebenin adi 3 herfden kicik, 15 herfden boyuk, ve ya bosh ola bilmez!");
                }
            } 
        }
        public string Surname
        {
            get
             {
                return _surname;
            }
            set
            {
                if(!string.IsNullOrEmpty(value) && value.Length >= 3 && value.Length <= 15)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Telebenin soyadi 3 herfden kicik, 15 herfden boyuk, ve ya bosh ola bilmez!");
                }
            }
        }
        public double Avarage { 
            get 
            { 
            return _avarage;
            }
            set
            { 
                if(value >= 0 && value <=100)
                {
                    _avarage = value;
                }
                else
                {
                    Console.WriteLine("Ortalama 0-100 intervalinda olmalidi");

                }
            } }
         public Student()
        {
        
            _id++;
            id = _id;
        }
    }
}
