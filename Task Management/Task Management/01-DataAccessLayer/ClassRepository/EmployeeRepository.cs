using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.ClassRepository
{
   public class EmployeeRepository : BaseRepository<Employee>
    {
        TaskManagementContext _context; 

        internal EmployeeRepository(TaskManagementContext context) : base(context)
        {
            _context = context;
        }

        
        public int Get(string Email,string Password)
        {
            try
            {
                int employeeID = _context.Set<Employee>().FirstOrDefault(x => x.EMail == Email && x.Password == Password).EmployeeID;
                return employeeID;
            }
            catch (Exception)
            {

                throw;
            } 
        }


        public int Get(string Email)
        {
            try
            {
                int employeeID = _context.Set<Employee>().FirstOrDefault(x => x.EMail == Email).EmployeeID;
                return employeeID;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Employee> GetEmployee(int id)
        {
            try
            {
                List<Employee> listEmployee = _context.Set<Employee>().Where(pm => pm.EmployeeTypeID == id && pm.isDelected == false).ToList();
                return listEmployee;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

       
    }
}
