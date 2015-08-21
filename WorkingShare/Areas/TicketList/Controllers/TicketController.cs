using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WorkingShare.Database;

namespace WorkingShare.Areas.TicketList.Controllers
{
    public class TicketController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<tTicket> Get()
        {
            using (var ctx = new TicketEntities())
            {
                return ctx.tTicket;
            }
        }

        // GET api/<controller>/5
        public tTicket Get(int id)
        {
            using (var ctx = new TicketEntities())
            {
                var entity = ctx.tTicket.SingleOrDefault(p => p.TicketId == id);
                return entity;
            }
        }

        // POST api/<controller>
        public void Post([FromBody]tTicket value)
        {
            using (var ctx = new TicketEntities())
            {
                value.TicketId = 0;//TODO:追加処理
                ctx.tTicket.Add(value);
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]tTicket value)
        {
            using (var ctx = new TicketEntities())
            {

                var entity = ctx.tTicket.SingleOrDefault(p => p.TicketId == id);

                if (entity == null)
                    return;

                ctx.tTicket.Attach(value);
                ctx.Entry(value).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            using (var ctx = new TicketEntities())
            {
                var entity = ctx.tTicket.SingleOrDefault(p => p.TicketId == id);
                if (entity != null)
                {
                    ctx.tTicket.Remove(entity);
                    ctx.SaveChanges();
                }
            }
        }
    }
}