using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.ClassRepository
{
    public class TasksRepository : BaseRepository<Tasks>
    {
        internal TasksRepository(TaskManagementContext context) : base(context)
        {
        }
    }
}
