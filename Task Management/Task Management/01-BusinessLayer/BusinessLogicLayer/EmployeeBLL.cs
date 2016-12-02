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
    public class EmployeeBLL : IBusiness<Employee>
    {
        UnitOfWork _uow;
        public EmployeeBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(Employee item)
        {
            if (string.IsNullOrWhiteSpace(item.FirstName) || string.IsNullOrWhiteSpace(item.LastName) || string.IsNullOrWhiteSpace(item.Phone) || string.IsNullOrWhiteSpace(item.EMail) || string.IsNullOrWhiteSpace(item.Password))
            {
                return false;
            }

            _uow.EmployeeRepository.Add(item);
            return _uow.ApplyChanges();
        }

        public Employee Get(int id)
        {
            return _uow.EmployeeRepository.Get(id);
        }

        public List<Employee> GetAll()
        {
            return _uow.EmployeeRepository.GetAll();
        }

        public bool Get(string Email)
        {
            try
            {
                _uow.EmployeeRepository.Get(Email);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Remove(Employee item)
        {
            try
            {
                _uow.EmployeeRepository.Remove(item);
                return _uow.ApplyChanges();
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Employee item)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(item.FirstName) && !string.IsNullOrWhiteSpace(item.LastName) && !string.IsNullOrWhiteSpace(item.Phone) && !string.IsNullOrWhiteSpace(item.EMail) && !string.IsNullOrWhiteSpace(item.Password))
                {
                    _uow.EmployeeRepository.Update(item);
                    return _uow.ApplyChanges();
                }
            }
            catch (Exception)
            {

                return false;
            }

            return false;
        }

        public Employee Get(string Email, string Password)
        {
            try
            {
                int id = _uow.EmployeeRepository.Get(Email, Password);
                return Get(id);
            }
            catch (Exception )
            {

                throw new Exception("Kullanıcı Kayıtlı Değil!");
            }
        }

        public Employee GetEmployee(string Email)
        {
            try
            {
                int id = _uow.EmployeeRepository.Get(Email);
                return Get(id);
            }
            catch (Exception)
            {

                throw new Exception("Kullanıcı Sistemimizde Yok");
            }
        }

        public List<Employee> GetEmployee(int id)
        {
            try
            {
                List<Employee> employeeList = _uow.EmployeeRepository.GetEmployee(id);
                return employeeList;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
