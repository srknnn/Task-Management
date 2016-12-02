using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities
{
   public class Project
    {
        public Project()
        {
            isActive = true;
        }

        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Kim oluşturdu
        public virtual Employee Employee { get; set; }
        public int EmployeeID { get; set; }

        public virtual Customer Customer { get; set; }
        public int CustomerID { get; set; }

        public DateTime RequiredStartDate { get; set; }
        public DateTime RequiredEndDate { get; set; }

        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectFinishDate { get; set; }

        public bool isActive { get; set; }
        public bool isDelected { get; set; }

    }
}
