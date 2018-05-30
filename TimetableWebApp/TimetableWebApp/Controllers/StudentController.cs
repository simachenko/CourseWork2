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
    public class StudentController : ApiController
    {
        IStudent student;

        protected StudentController()
        {
            Ninject.NinjectContext.SeUp(new Ninject.Configurations.NinjectConfig());
            student = Ninject.NinjectContext.Get<IStudent>();
        }

        // GET: api/StudentLesson
        [HttpGet]
        [Route("api/StudentLesson/GetLessons/{group}")]
        public HttpResponseMessage GetLessons(string groupName)
        {
            if (!Regex.IsMatch(groupName, @"^[\d|\D]{1,40}$"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Name is too long!");
            if (groupName == null || groupName.Length == 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert group name");
            if (!Regex.IsMatch(groupName, @"^\w{2}-\d{3}"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert group name");
            var list = ModelMap.LessonDomainToView(student.getAllLessons(groupName));
            var response = Request.CreateResponse<IEnumerable<LessonViewModel>>(HttpStatusCode.OK, list);
            return response;
        }

        
    }
}
