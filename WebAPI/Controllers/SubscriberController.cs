using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class SubscriberController : ApiController
    {
        private VishalWebAPIDemoEntities _entities = new VishalWebAPIDemoEntities();
        public IEnumerable<tbl_Subscribers> Get()
        {
            IEnumerable<tbl_Subscribers> list;

            try
            {
                list = _entities.tbl_Subscribers.AsEnumerable();
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        // POST: api/Subscriber
        public void Post(tbl_Subscribers sub)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _entities.tbl_Subscribers.Add(sub);
                    _entities.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // PUT: api/Subscriber/5
        public void Put(tbl_Subscribers sub)
        {
            if (ModelState.IsValid)
            {
                _entities.Entry(sub).State = EntityState.Modified;
                try
                {
                    _entities.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // DELETE: api/Subscriber/5
        public void Delete(int id)
        {
            tbl_Subscribers dlt = _entities.tbl_Subscribers.Find(id);
            if (dlt != null)
            {
                try
                {
                    _entities.tbl_Subscribers.Remove(dlt);
                    _entities.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
