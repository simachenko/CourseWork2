using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TimetableWebApp.Controllers
{
    public class DisciplineLessonController : ApiController
    {
        // GET: api/DisciplineLesson
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DisciplineLesson/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DisciplineLesson
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DisciplineLesson/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DisciplineLesson/5
        public void Delete(int id)
        {
        }
    }
}
