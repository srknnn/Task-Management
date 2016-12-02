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
    public class EmployeeTypeBLL : IBusiness<EmployeeType>
    {
        UnitOfWork _uow;
        public EmployeeTypeBLL()
        {
            _uow = new UnitOfWork();
        }
        public bool Add(EmployeeType item)
        {
            if (string.IsNullOrWhiteSpace(item.Name))
            {
                return false;
            }

            _uow.EmployeeTypeRepository.Add(item);
            return _uow.ApplyChanges(); ;
        }

        public EmployeeType Get(int id)
        {
            return _uow.EmployeeTypeRepository.Get(id);
        }

        public List<EmployeeType> GetAll()
        {
            return _uow.EmployeeTypeRepository.GetAll();
        }

        public bool Remove(EmployeeType item)
        {
            try
            {
                _uow.EmployeeTypeRepository.Remove(item);
                return _uow.ApplyChanges();
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(EmployeeType item)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(item.Name))
                {
                    _uow.EmployeeTypeRepository.Update(item);
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
