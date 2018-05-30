using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Interfaces;
using TimetableWebApp.Models.TimetableViewModels;
using TimetableWebApp.ModelMapper;
namespace TimetableWebApp.Controllers
{
    public class AuditoryLessonControllerController : ApiController
    {
        IEditor<>
        // GET: api/AuditoryLessonController
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AuditoryLessonController/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AuditoryLessonController
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AuditoryLessonController/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AuditoryLessonController/5
        public void Delete(int id)
        {
        }
    }
}
