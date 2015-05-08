using KuasCore.Dao;
using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Services.Impl
{
    public class courseSerivce : Icourseservice
    {

        public IcourseDao courseDao { get; set; }

        public void Addcourse(course course)
        {
            courseDao.Addcourse(course);
        }
       
        public IList<course> GetAllcourse()
        {
            return courseDao.GetAllcourse();
        }

        public course GetcourseById(string course_id)
        {
            return courseDao.GetcourseById(course_id);
        }

    }

}


