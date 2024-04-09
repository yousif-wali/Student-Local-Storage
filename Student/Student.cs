using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }

        public Student(int id, string name, string department, string address, DateTime dob)
        {
            this.ID = id;
            this.Name = name;
            this.Department = department;
            this.Address = address;
            this.Dob = dob;
        }
    }
}
