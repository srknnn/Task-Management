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
   public class ProjectEmployeesBLL:IBusiness<ProjectEmployees>
    {


        UnitOfWork _uow;
        public ProjectEmployeesBLL()
        {
            _uow = new UnitOfWork();
        }

        public bool Add(ProjectEmployees item)
        {
            _uow.ProjectEmployeesRepository.Add(item);
            
            return _uow.ApplyChanges();
        }

        public bool Remove(ProjectEmployees item)
        {


            _uow.ProjectEmployeesRepository.Remove(item);
            return _uow.ApplyChanges();
        }

        public bool Update(ProjectEmployees item)
        {
            _uow.ProjectEmployeesRepository.Update(item);
            return _uow.ApplyChanges();
        }

        public ProjectEmployees Get(int id)
        {
            return _uow.ProjectEmployeesRepository.Get(id);
        }

        public List<ProjectEmployees> GetAll()
        {
            return _uow.ProjectEmployeesRepository.GetAll();
        }

        public object GetProject(int EmployeeID)
        {

            object query = GetAll().Where(x => x.EmployeeID == EmployeeID && x.project.isActive == true && x.project.isDelected == false)
                  .Select(x => new
                  {
                      x.project.ProjectID,
                      x.project.Name,
                      x.project.Customer.ContactName
                  }).ToList();

            return query;
        }
        
        public object GetProjectTask(int id)
        {
            object query = GetAll().Where(x => x.EmployeeID == id && x.project.isActive == true && x.project.isDelected == false)
              .Select(x => new
              {
                  x.project.ProjectID,
                  Proje_Adı = x.project.Name,
                  Proje_Açıklaması = x.project.Description,
                  Proje_Başlama_Tarihi = x.project.ProjectStartDate,
                  Proje_Bitiş_Tarihi = x.project.ProjectFinishDate
              }).ToList();

            return query;
        }
        public object GetEmployeeCustomer(int employeeID)
        {
            object query = GetAll().Where(x => x.EmployeeID == employeeID).Select(x => new
            {

                x.project.Customer.CustomerID,
                x.project.Customer.CompanyName,
                x.project.Customer.ContactName,
                x.project.Customer.Phone

            }).Distinct().ToList();

            return query;
        }

        public object GetEmployee(int ProjectId)
        {
           object query = GetAll().Where(x => x.ProjectID == ProjectId && x.project.isActive == true && x.project.isDelected == false)
                    .Select(x => new
                    {
                        x.EmployeeID,
                        x.employee.FullName,
                        x.employee.EmployeeType.Name,
                    }).ToList();

            return query;
        }

        public object EmployeeAndProject(int ProjectId)
        {
              object query =GetAll().Where(x => x.ProjectID == ProjectId).Select(x => new
                 {
                     x.employee.EmployeeID,
                     x.ProjectID,
                     x.employee.FullName,
                     x.employee.EmployeeType.Name

                 }).ToList();

            return query;
        }

    }
}
