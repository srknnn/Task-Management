using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.ClassRepository
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        TaskManagementContext _context;
        internal CustomerRepository(TaskManagementContext context) : base(context)
        {
            _context = context;
        }
        //mail kontrol deneme
       
        public int Get(string Email)
        {
            try
            {
                int customerID = _context.Set<Customer>().FirstOrDefault(x => x.Email==Email).CustomerID;
                return customerID;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
