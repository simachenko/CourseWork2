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
    public class TeacherLessonController : ApiController
    {
        ITeacher teacher = Ninject.NinjectContext.Get<ITeacher>();
        
        // GET: api/TeacherLesson
        
        public HttpResponseMessage Get(string teacherName)
        {
            var list = ModelMap.LessonDomainToView(teacher.getLessonsByTeacher(teacherName));
            var response = Request.CreateResponse<IEnumerable<LessonViewModel>>(HttpStatusCode.OK, list);
            return response;
        }

        // GET: api/TeacherLesson/5
        public string Get(int id)
        {
            return "value";

        }

        // POST: api/TeacherLesson
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TeacherLesson/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TeacherLesson/5
        public void Delete(int id)
        {
        }
    }
}
