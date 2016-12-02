using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities
{
   public class Tasks
    {
        public int TaskID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }

        public virtual Status Status { get; set; }
        public int StatusID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Employee Employee { get; set; }
        public int? EmployeeID { get; set; }

        public virtual Employee Manager { get; set; }
        public int ManagerID { get; set; }

    }
}
