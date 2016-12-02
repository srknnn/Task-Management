using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.ClassRepository
{
   public class ProjectRepository : BaseRepository<Project>
    {
       TaskManagementContext _context; 

        internal ProjectRepository(TaskManagementContext context) : base(context)
        {
            _context = context;   
        }

       


        public object  GetProjects(int employeeID)
        {
            

            var query = _context.Set<ProjectEmployees>().Where(x => x.EmployeeID == employeeID).Select(x=> new
            {
                x.project.Name

            }).ToList();



            return query;
                //.Join(_context.ProjectEmployees,
                //p => p.ProjectID,
                //pe => pe.ProjectID,
                //(p, pe) => new { p, pe })
                //.Where(ppe => ppe.p.ProjectID == ppe.pe.ProjectID)
                //.Join(_context.Employees, ppee => ppee.EmployeeID, em => em.EmployeID, 
                //(ppee,em),);
                

        }
    }
}
