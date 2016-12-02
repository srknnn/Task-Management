using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities
{
    public class Employee
    {

        public Employee()
        {
            Projects = new HashSet<Project>();
        }
        
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public int EmployeeTypeID { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public bool isDelected { get; set; }

        public ICollection<Project> Projects { get; set; }

        public override string ToString()
        {
            return FullName + "-" + EmployeeType.Name ;
        }

    }
}
