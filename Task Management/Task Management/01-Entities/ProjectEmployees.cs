using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities
{
   public class ProjectEmployees
    {
       public virtual Employee employee { get; set; }
       public int EmployeeID { get; set; }
       public virtual Project project { get; set; }
       public int ProjectID { get; set; }
       public bool isEmployeeActive { get; set; }
    }
}
