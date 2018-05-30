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
    public class StudentLessonController : ApiController
    {
        IStudent student = Ninject.NinjectContext.Get<IStudent>();

        // GET: api/StudentLesson
        public IEnumerable<LessonViewModel> Get(string group)
        {
            return ModelMap.LessonDomainToView(student.getAllLessons(group));
        }

        // GET: api/StudentLesson/5
        //public LessonViewModel Get(int id)
        //{
        //    return;
        //}

        //// POST: api/StudentLesson
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/StudentLesson/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/StudentLesson/5
        //public void Delete(int id)
        //{
        //}
    }
}
