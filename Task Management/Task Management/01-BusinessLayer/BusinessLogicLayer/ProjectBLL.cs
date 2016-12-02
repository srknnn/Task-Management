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
   public class ProjectBLL:IBusiness<Project>
    {
       UnitOfWork _uow;
       public ProjectBLL()
       {
           _uow = new UnitOfWork();
       }

       public bool Add(Project item)
       {
           if (string.IsNullOrWhiteSpace(item.Name))
           {
               return false;
           }

           _uow.ProjectRepository.Add(item);
           return _uow.ApplyChanges();
       }

       public bool Remove(Project item)
       {
           try
           {
               _uow.ProjectRepository.Remove(item);
               return _uow.ApplyChanges();
           }
           catch (Exception)
           {

               return false;
           }
       }

       public bool Update(Project item)
       {
           try
           {
                   _uow.ProjectRepository.Update(item);
                   return _uow.ApplyChanges();    
           }
           catch (Exception)
           {

               return false;
           }
            
       }

       public Project Get(int id)
       {
           return _uow.ProjectRepository.Get(id);
       }

       public List<Project> GetAll()
       {
           return _uow.ProjectRepository.GetAll();
       }

        public object CustomerList(int customerID)
        {
            object query = GetAll()
                    .Where(x => x.CustomerID == customerID && x.isActive == true && x.isDelected == false).Select(x => new
                    {
                        x.ProjectID,
                        x.Name,
                        x.RequiredStartDate,
                        x.RequiredEndDate
                    }).Distinct().ToList();

            return query;
        }
       
    }
}
