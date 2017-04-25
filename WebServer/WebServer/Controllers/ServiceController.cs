using DataAccess;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServer.Controllers
{
    public class ServiceController : ApiController
    {
        IRepository<Service> _rep = new ServiceRepository();
        // GET api/Kind
        public IEnumerable<Service> Get()
        {
            return _rep.GetAll();
        }

        // GET api/Kind/5
        public Service Get(int id)
        {
            return _rep.GetById(id);
        }
    }
}