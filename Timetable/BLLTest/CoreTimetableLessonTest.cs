using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.DTO;
using System.Collections.Generic;
using System.Diagnostics;
using BLL.Core;

namespace BLLTest
{
    [TestClass]
    class CoreTimetableLessonTest
    {
        List<LessonDTO> ldl;
        LessonDTO ld;
        CoreTimetable ct;
        [TestInitialize]
        public void testInitialize()
        {
            Debug.WriteLine("Test initialize");
            ld = new LessonDTO();
            ld.auditory = 6.104;
            ld.day = 1;
            ld.discipline = "Mathematic";
            ld.group = "219";
            ld.LessonId = 1;
            ld.teacher = "Valera";

            ct = new CoreTimetable();
            ct.CreateLesson(ld);
            ldl.Add(ld);
        }

        [TestCleanup]
        public void testCleanup()
        {
            Debug.WriteLine("Test cleanup");
            ct.DeleteLesson(1);
        }

        [TestMethod]
        public void getLessonByGroup()
        {
            CollectionAssert.AreEquivalent(ct.GetLessonByGroup(ld.group), ldl);
        }
        [TestMethod]
        public void getLessonByTeacher()
        {
            CollectionAssert.AreEquivalent(ct.GetLessonByTeacher(ld.teacher), ldl);
        }
        [TestMethod]
        public void getLessonByAuditory()
        {
            CollectionAssert.AreEquivalent(ct.GetLessonByAuditory(ld.auditory), ldl);
        }
        [TestMethod]
        public void getLessonByDiscipline()
        {
            CollectionAssert.AreEquivalent(ct.GetLessonByDiscipline(ld.discipline), ldl);
        }
        [TestMethod]
        public void getLesson()
        {
            Assert.AreEqual(ct.getLesson(ld.LessonId), ld);
        }
    }
}
