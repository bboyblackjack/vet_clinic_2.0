using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataModel;

namespace DataAccess
{
    public class ServiceRepository: IRepository<Service>
    {
        DataContext db;

        public ServiceRepository()
        {
            this.db = new DataContext();
        }

        public List<Service> GetAll()
        {
            List<Service> allServices = db.Set<Service>().ToList();

            return allServices;
        }

        public Service GetById(int id)
        {
            var service = db.Services.Find(id);

            return service;
        }
    }
}
