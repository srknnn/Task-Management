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
    public class CustomerBLL : IBusiness<Customer>
    {

        UnitOfWork _uow;
        public CustomerBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(Customer item)
        {
            if (string.IsNullOrWhiteSpace(item.ContactName)||string.IsNullOrWhiteSpace(item.CompanyName)||string.IsNullOrWhiteSpace(item.Address)||string.IsNullOrWhiteSpace(item.Email)||string.IsNullOrWhiteSpace(item.Phone))
            {
                return false;
            }
          
            _uow.CustomerRepository.Add(item);
            return _uow.ApplyChanges();
        }

        public Customer Get(int id)
        {
            return _uow.CustomerRepository.Get(id);
        }
        // mail kontrol deneme
        public bool Get(string Email)
        {
            try
            {
                _uow.CustomerRepository.Get(Email);
                return true;
            }
            catch (Exception)
            {

                return false; 
            }
        }
        


        public List<Customer> GetAll()
        { 
            return _uow.CustomerRepository.GetAll();
        }

        public bool Remove(Customer item)
        {
            try
            {
                _uow.CustomerRepository.Remove(item);
                return _uow.ApplyChanges();
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Customer item)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(item.ContactName) && !string.IsNullOrWhiteSpace(item.CompanyName) && !string.IsNullOrWhiteSpace(item.Address) && !string.IsNullOrWhiteSpace(item.Email) && !string.IsNullOrWhiteSpace(item.Phone))
                {
                    _uow.CustomerRepository.Update(item);
                    return _uow.ApplyChanges();
                }
            }
            catch (Exception)
            {

                return false;
            }

            return false;
        }
    }
}
