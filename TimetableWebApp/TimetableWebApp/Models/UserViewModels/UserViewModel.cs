using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimetableWebApp.Models.UserViewModels
{
    public class UserViewModel
    {
        public int UserId { set; get; }
        public string name { set; get; }
        public string key { set; get; }
        public string surname { set; get; }
        public string nickname { set; get; }
        public string password { set; get; }
    }
}