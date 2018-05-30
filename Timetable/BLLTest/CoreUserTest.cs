using BLL.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Core;
using System.Diagnostics;
using BLL.Core;

namespace BLLTest
{
    [TestClass]
    class CoreUserTest
    {
        List<UserDTO> udl;
        UserDTO ud;
        CoreUser cu;
        IKernel kern = new StandardKernel(new BLL.NinjectConfig.NinjectConfigurations());
        [TestInitialize]
        public void testInitialize()
        {
            Debug.WriteLine("Test initialize");
            kern.Get<CoreUser>();
            ud = new UserDTO("Valera", "Korch", "student", "ValeraKorch", "1234valera");
            ud.UserId = 1;
            cu.CreateUser(ud);
            udl.Add(ud);

        }
        [TestCleanup]
        public void testCleanup()
        {
            Debug.WriteLine("Test cleanup");
            cu.DeleteUser(1);
        }
        public void allItemsAreNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(cu.GetAllUser(), "Not null failed!");
        }
        [TestMethod]
        public void Authorization()
        {
            Assert.AreEqual(cu.Authorization(ud.nickname, ud.password), null);
        }
        [TestMethod]
        public void getUserId()
        {
            Assert.AreEqual(cu.GetUser(ud.UserId), ud);
        }
        public void getUserSurname()
        {
            Assert.AreEqual(cu.GetUser(ud.surname), ud);
        }
        public void getAllUser()
        {
            CollectionAssert.AreEquivalent(cu.GetAllUser(), udl);
        }
    }
}
