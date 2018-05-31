using BLL.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Core;
using System.Diagnostics;
using Ninject;

namespace BLLTest
{
    [TestClass]
    public class CoreTimetableGroupTest
    {
        List<GroupDTO> gdl;
        GroupDTO gd;
        CoreTimetable ct;
        IKernel kern = new StandardKernel(new BLL.NinjectConfig.NinjectConfigurations());
        [TestInitialize]
        public void testInitialize()
        {
            Debug.WriteLine("Test initialize");
            gd = new GroupDTO();
            gd.name = "219";
            gd.GroupId = 1;
            kern.Get<CoreTimetable>();

            
            ct.CreateGroup(gd);
            gdl.Add(gd);

        }
        [TestCleanup]
        public void testCleanup()
        {
            Debug.WriteLine("Test cleanup");
            ct.DeleteGroup(gd.name);
            ct.DeleteLesson(1);
        }
        [TestMethod]
        public void allItemsAreNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(ct.getGroups(), "Not null failed!");
        }

        [TestMethod]
        public void getGroups()
        {
            CollectionAssert.AreEquivalent(ct.getGroups(), gdl);
        }
        [TestMethod]
        public void getGroup()
        {
            Assert.AreEqual(ct.getGroup(gd.name), gd);
        }


    }
}
