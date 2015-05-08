using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace KuasWebApp.Controllers
{
    public class courseController : ApiController
    {
        //// GET: course
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public IcourseService courseSerivce { get; set; }

        [HttpPost]
        public course Addcourse(course course)
        {
            CheckcourseIsNotNullThrowException(course);


            try
            {
                courseSerivce.Addcourse(course);
                return courseSerivce.GetcourseById(course.course_id);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        private void CheckcourseIsNotNullThrowException(course course)
        {
            throw new NotImplementedException();
        }


        [HttpGet]
        public IList<course> GetAllcourse()
        {
            return courseSerivce.GetAllcourse();
        }

        [HttpGet]
        [ActionName("byId")]
        public course GetcourseById(string course_id)
        {
            var course = courseSerivce.GetcourseById(course_id);

            if (course == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return course;
        }

        /// <summary>
        ///     檢查員工資料是否存在，如果不存在則拋出錯誤.
        /// </summary>
        /// <param name="course">
        ///     員工資料.
        /// </param>
        private void CheckcourseIsNullThrowException(course course)
        {
            course dbcourse = courseSerivce.GetcourseById(course_id);

            if (dbcourse == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        ///     檢查員工資料是否存在，如果存在則拋出錯誤.
        /// </summary>
        /// <param name="course">
        ///     員工資料.
        /// </param>
        private void CheckcourseIsNotNullThrowException(course course)
        {
            course dbcourse = courseSerivce.GetcourseById(course_id);

            if (dbcourse != null)
            {
                throw new HttpResponseException(HttpStatusCode.Conflict);
            }
        }


        public string course_id { get; set; }
    }
}

