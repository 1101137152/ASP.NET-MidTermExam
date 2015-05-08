
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class courseDao : GenericDao<course>, IcourseDao
    {

        override protected IRowMapper<course> GetRowMapper()
        {
            return new courseRowMapper();
        }

        public void Addcourse(course course)
        {
            string command = @"INSERT INTO course (course_id, course_name, course_Description) VALUES (@course_id, @course_name, @course_Description);";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("course_id", DbType.String).Value = course_id;
            parameters.Add("course_name", DbType.String).Value = course_name;
            parameters.Add("course_Description", DbType.String).Value = course_Description;

            ExecuteNonQuery(command, parameters);
        }

        public IList<course> GetAllcourse()
        {
            string command = @"SELECT * FROM course ORDER BY course_id ASC";
            IList<course> course = ExecuteQueryWithRowMapper(command);
            return course;
        }

        public course GetcourseById(string course_id)
        {
            string command = @"SELECT * FROM course WHERE course_id = @course_id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("course_id", DbType.String).Value = course_id;

            IList<course> course = ExecuteQueryWithRowMapper(command, parameters);
            if (course.Count > 0)
            {
                return course[0];
            }

            return null;
        }

        public object course_id { get; set; }

        public object course_name { get; set; }

        public object course_Description { get; set; }
    }
}