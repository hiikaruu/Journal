using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp3.Models.Decanat
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public double Raiting { get; set; }
        public string Description { get; set; }

    }
    internal class Group
    {
        public string Name { get; set; }
        public IList<Student> Students { get; set; }
        public string Description { get; set; }
    }
}
