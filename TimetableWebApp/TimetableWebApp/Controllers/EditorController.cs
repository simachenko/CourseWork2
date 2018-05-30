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
    public class EditorController : ApiController
    {

        IEditor editor;

        public EditorController()
        {

            Ninject.NinjectContext.SeUp(new Ninject.Configurations.NinjectConfig());
            editor = Ninject.NinjectContext.Get<IEditor>();
        }

        // GET: api/Editor
        [HttpGet]
        [Route("api/Editor/GetLessonsByGroup/{group}")]
        public HttpResponseMessage GetLessonsByGroup(string groupName)
        {
            if (!Regex.IsMatch(groupName, @"^[\d|\D]{1,40}$"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Name is too long!");
            if (groupName == null || groupName.Length == 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert group name");
            if (!Regex.IsMatch(groupName, @"^\w{2}-\d{3}"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert group name");
            var list = ModelMap.LessonDomainToView(editor.getAllLessons(groupName));
            var response = Request.CreateResponse<IEnumerable<LessonViewModel>>(HttpStatusCode.OK, list);
            return response;
        }
        [HttpGet]
        [Route("api/Editor/GetGroups")]
        public IEnumerable<GroupViewModel> GetGroups()
        {
            return ModelMap.GroupDomainToView(editor.getAllGroups());
        }

        // GET: api/Editor/5
        //public GroupViewModel Get(int id)
        //{
            
        //    return "value";
        //}

        // POST: api/Editor
        [HttpPost]
        [Route("api/Editor/CreateGroup/{name}")]
        public HttpResponseMessage CreateGroup(string name)
        {
            GroupViewModel group = new GroupViewModel();
            group.name = name;
            if (!Regex.IsMatch(group.name, @"^[\d|\D]{1,40}$"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Name is too long!");
            if (group.name == null || group.name.Length == 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert group name");
            if (!Regex.IsMatch(group.name, @"^\w{2}-\d{3}"))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Pelease insert group name");
            editor.addNewGroup(ModelMapper.ModelMap.GroupViewToDomain(group));
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpPost]
        [Route("api/Editor/CreateLesson/{discipline}/{group}/{teacher}/{day}/{audithory}")]
        public HttpResponseMessage CreateLesson(string discipline, string group, string teacher, int day, double audithory)
        {
            LessonViewModel lesoon = new LessonViewModel();
            lesoon.group = group;
            lesoon.discipline = discipline;
            lesoon.day = day;
            lesoon.auditory = audithory;
            lesoon.teacher = teacher;

            if (!ValitadionLesson(lesoon))
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            editor.addNewLesson(ModelMap.LessonViewToDomain(lesoon));
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        private bool ValitadionLesson(LessonViewModel lesson)
        {
            if (lesson.auditory > 2.0 || lesson.auditory < 0.0009)
                return false;
            if (!Regex.IsMatch(lesson.discipline, @"^[\d|\D]{1,40}$"))
                return false;
            if (!Regex.IsMatch(lesson.teacher, @"^[\d|\D]{1,40}$"))
                return false;
            if (Regex.IsMatch(lesson.discipline, @"^.*\d+.*$"))
                return false;
            if (Regex.IsMatch(lesson.teacher, @"^.*\d+.*$"))
                return false;
            if (!Regex.IsMatch(lesson.group, @"^\w{2}-\d{3}"))
                return false;
            if (lesson.day > 6 || lesson.day < 1)
                return false;
            return true;

        }
        // PUT: api/Editor/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Editor/5
        [HttpDelete]
        [Route("api/Editor/DeleteLesson/{id}")]
        public void DeleteLesson(int id)
        {
            editor.removeLesson(id);
        }
        [HttpDelete]
        [Route("api/Editor/DeleteGroup/{name}")]
        public void DeleteGroup(string name)
        {
            editor.removeGroup(name);
        }
    }
}
