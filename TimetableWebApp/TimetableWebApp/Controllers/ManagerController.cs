using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Interfaces;
using TimetableWebApp.Models.TimetableViewModels;
using TimetableWebApp.ModelMapper;
using System.Text.RegularExpressions;

namespace TimetableWebApp.Controllers
{
    public class ManagerController : ApiController
    {
        IManager manager;

        protected ManagerController()
        {
            Ninject.NinjectContext.SeUp(new Ninject.Configurations.NinjectConfig());
            manager = Ninject.NinjectContext.Get<IManager>();
        }

        // GET: api/Manager
        [HttpGet]
        [Route("api/Manager/GetLessonsByName/{teacherName}")]
        public HttpResponseMessage GetLessonsByName(string teacherName)
        {
            if (!Regex.IsMatch(teacherName, @"^[\d|\D]{1,40}$"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Name is too long!");
            if (teacherName == null || teacherName.Length == 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert name");
            if (Regex.IsMatch(teacherName, @"^.*\d+.*$"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert only letters");
            var list = ModelMap.LessonDomainToView(manager.getLessonsByTeacher(teacherName));
            var response = Request.CreateResponse<IEnumerable<LessonViewModel>>(HttpStatusCode.OK, list);
            return response;
        }
        [HttpGet]
        [Route("api/Manager/GetLessonsByGroup/{groupName}")]
        public HttpResponseMessage GetLessonsByGroup(string groupName)
        {
            if (!Regex.IsMatch(groupName, @"^[\d|\D]{1,40}$"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Name is too long!");
            if (groupName == null || groupName.Length == 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert group name");
            if (!Regex.IsMatch(groupName, @"^\w{2}-\d{3}"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert group name");
            var list = ModelMap.LessonDomainToView(manager.getLessonsByGroup(groupName));
            var response = Request.CreateResponse<IEnumerable<LessonViewModel>>(HttpStatusCode.OK, list);
            return response;
        }
        [HttpGet]
        [Route("api/Manager/GetLessonsByDiscipline/{discipline}")]
        public HttpResponseMessage GetLessonsByDiscipline(string discipline)
        {
            if (!Regex.IsMatch(discipline, @"^[\d|\D]{1,40}$"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Discipline is too long!");
            if (discipline == null || discipline.Length == 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert Discipline");
            if (Regex.IsMatch(discipline, @"^.*\d+.*$"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert only letters");
            var list = ModelMap.LessonDomainToView(manager.getLessonsByDiscipline(discipline));
            var response = Request.CreateResponse<IEnumerable<LessonViewModel>>(HttpStatusCode.OK, list);
            return response;
        }
        [HttpGet]
        [Route("api/Manager/GetLessonsByAudithory/{audithory}")]
        public HttpResponseMessage GetLessonsByAudithory(double audithory)
        {
            if (audithory > 2.0 || audithory < 0.0009)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert only double; example 6.200");
            var list = ModelMap.LessonDomainToView(manager.getLessonsByAuditory(audithory));
            var response = Request.CreateResponse<IEnumerable<LessonViewModel>>(HttpStatusCode.OK, list);
            return response;
        }

        // GET: api/Manager/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Manager
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Manager/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Manager/5
        public void Delete(int id)
        {
        }
    }
}
