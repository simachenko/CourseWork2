using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Interfaces;
using TimetableWebApp.Models.TimetableViewModels;
using TimetableWebApp.ModelMapper;
using System.Text;
using System.Text.RegularExpressions;   
namespace TimetableWebApp.Controllers
{
    public class TeacherController : ApiController
    {
        ITeacher teacher = Ninject.NinjectContext.Get<ITeacher>();
        
        // GET: api/TeacherLesson
        [HttpGet]
        [Route("api/TeacherLesson/GetLessonsByName/{teacherName}")]
        public HttpResponseMessage GetLessonsByName(string teacherName)
        {
            if (!Regex.IsMatch(teacherName, @"^[\d|\D]{1,40}$"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Name is too long!");
            if (teacherName == null || teacherName.Length == 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert name");
            if (Regex.IsMatch(teacherName, @"^.*\d+.*$"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert only letters");
            var list = ModelMap.LessonDomainToView(teacher.getLessonsByTeacher(teacherName));
            var response = Request.CreateResponse<IEnumerable<LessonViewModel>>(HttpStatusCode.OK, list);
            return response;
        }
        [HttpGet]
        [Route("api/TeacherLesson/GetLessonsByGroup/{groupName}")]
        public HttpResponseMessage GetLessonsByGroup(string groupName)
        {
            if (!Regex.IsMatch(groupName, @"^[\d|\D]{1,40}$"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Name is too long!");
            if (groupName == null || groupName.Length == 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert group name");
            if (!Regex.IsMatch(groupName, @"^\w{2}-\d{3}"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert group name");
            var list = ModelMap.LessonDomainToView(teacher.getLessonsByGroup(groupName));
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
