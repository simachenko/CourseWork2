using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimetableWebApp.Models.TimetableViewModels;
namespace TimetableWebApp.Controllers
{
    public class LessonController : ApiController
    {
        // GET: api/Lesson
        public IEnumerable<LessonViewModel> Get()
        {
            
        }

        // GET: api/Lesson/5
        public LessonViewModel Get(int id)
        {
        }

        // POST: api/Lesson
        public void Post([FromBody]LessonViewModel value)
        {
        }

        // PUT: api/Lesson/5
        public void Put(int id, [FromBody]LessonViewModel value)
        {
        }

        // DELETE: api/Lesson/5
        public void Delete(int id)
        {
        }
    }
}
