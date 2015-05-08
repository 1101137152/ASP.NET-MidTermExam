using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao
{
    public interface IcourseDao
    {

        void Addcourse(course course);

        IList<course> GetAllcourse();

        course GetcourseById(string course_id);

    }
}
