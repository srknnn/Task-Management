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
    public class TasksBLL : IBusiness<Tasks>
    {
        UnitOfWork _uow;
        public TasksBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(Tasks item)
        {
            if (string.IsNullOrWhiteSpace(item.Name) || string.IsNullOrWhiteSpace(item.Description))
            {
                return false;
            }

            _uow.TasksRepository.Add(item);
            return _uow.ApplyChanges();
        }

        public Tasks Get(int id)
        {
            return _uow.TasksRepository.Get(id);
        }

        public List<Tasks> GetAll()
        {
            return _uow.TasksRepository.GetAll();
        }

        public bool Remove(Tasks item)
        {
            try
            {
                _uow.TasksRepository.Remove(item);
                return _uow.ApplyChanges();
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(Tasks item)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(item.Name) && !string.IsNullOrWhiteSpace(item.Description))
                {
                    _uow.TasksRepository.Update(item);
                    return _uow.ApplyChanges();
                }
            }
            catch (Exception)
            {

                return false;
            }

            return false;
        }

        public object GetTask(int projectID,int status)
        {
          object query =  GetAll().Where(x => x.ProjectID == projectID && x.StatusID == status)
                   .Select(x => new
                   {
                       x.TaskID,
                       İş_Adı = x.Name,
                       İşi_Veren_Kişi = x.Manager.FullName,
                       İşin_Başlangıç_Tarih = x.StartDate,
                       İşin_Bitiş_Tarih = x.EndDate,
                   }).ToList();

            return query;
        }

        public object GetIdleTask(int ProjectId,int status)
        {
           object query = GetAll().Where(x => x.ProjectID == ProjectId && x.EmployeeID == null && x.StatusID == status)
                    .Select(x => new
                    {
                        x.TaskID,
                        x.Name,
                        x.StartDate,
                        x.EndDate,
                    }).ToList();

            return query;
        }
    }
}
