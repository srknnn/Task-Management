using _01_BusinessLayer.Abstractions;
using _01_DataAccessLayer;
using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BusinessLayer.BusinessLogicLayer
{
    public class CustomerRequestBLL : IBusiness<CustomerRequest>
    {
        UnitOfWork _uow;
        public CustomerRequestBLL()
        {
            _uow = new UnitOfWork();
        }
        public bool Add(CustomerRequest item)
        {

            if (string.IsNullOrWhiteSpace(item.Description))
            {
                return false;
            }

            _uow.CustomerRequestRepository.Add(item);
            return _uow.ApplyChanges();
        }

        public CustomerRequest Get(int id)
        {
            return _uow.CustomerRequestRepository.Get(id);
        }

        public List<CustomerRequest> GetAll()
        {
            return _uow.CustomerRequestRepository.GetAll();
        }

        public bool Remove(CustomerRequest item)
        {
            try
            {
                _uow.CustomerRequestRepository.Remove(item);
                return _uow.ApplyChanges();
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(CustomerRequest item)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(item.Description))
                {
                    _uow.CustomerRequestRepository.Update(item);
                    return _uow.ApplyChanges();
                }
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }

        public object EmployeeRequest(int EmployeeID)
        {
           object query = GetAll().Where(x => x.isActive == true && x.EmployeeID == EmployeeID).ToList();

            return query;
        }
    }
}
