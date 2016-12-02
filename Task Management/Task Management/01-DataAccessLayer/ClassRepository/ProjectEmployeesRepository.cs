using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.ClassRepository
{
   public class ProjectEmployeesRepository:BaseRepository<ProjectEmployees>
    {
       TaskManagementContext _context;
        internal ProjectEmployeesRepository(TaskManagementContext context) : base(context)
        {
            _context = context;   
        }

    }
}
