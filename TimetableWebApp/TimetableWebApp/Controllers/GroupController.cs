using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimetableWebApp.Models.TimetableViewModels;
namespace TimetableWebApp.Controllers
{
    public class GroupController : ApiController
    {
        // GET: api/Group
        public IEnumerable<GroupViewModel> Get()
        {
        }

        // GET: api/Group/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Group
        public void Post([FromBody]GroupViewModel value)
        {
        }

        // PUT: api/Group/5
        public void Put(int id, [FromBody]GroupViewModel value)
        {
        }

        // DELETE: api/Group/5
        public void Delete(int id)
        {
        }
    }
}
