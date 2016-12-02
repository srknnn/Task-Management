using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities
{
    public class CustomerRequest
    {
        public CustomerRequest()
        {
            RequestDate = DateTime.Now;
        }

        public int CustomerRequestID { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }
        public string Description { get; set; }
        public bool RequestType { get; set; }
        public DateTime RequestDate { get; set; }
        public bool isActive { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeID { get; set; }
    }
}
