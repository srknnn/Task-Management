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
    public class StatusBLL : IBusiness<Status>
    {

        UnitOfWork _uow;

        public StatusBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(Status item)
        {
            if (string.IsNullOrWhiteSpace(item.Name))
            {
                return false;
            }

            _uow.StatusRepository.Add(item);
            return _uow.ApplyChanges();
        }

        public Status Get(int id)
        {
            return _uow.StatusRepository.Get(id);
        }

        public List<Status> GetAll()
        {
            return _uow.StatusRepository.GetAll();
        }

        public bool Remove(Status item)
        {
            try
            {
                _uow.StatusRepository.Remove(item);
                return _uow.ApplyChanges();
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Status item)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(item.Name))
                {
                    _uow.StatusRepository.Update(item);
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
