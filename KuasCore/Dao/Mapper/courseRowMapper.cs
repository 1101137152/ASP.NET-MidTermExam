using KuasCore.Models;
using Spring.Data.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Mapper
{
    class EmployeeRowMapper : IRowMapper<course>
    {
        public course MapRow(IDataReader dataReader, int rowNum)
        {
            course target = new course();

            target.course_id = dataReader.GetString(dataReader.GetOrdinal("course_id"));
            target.course_name = dataReader.GetString(dataReader.GetOrdinal("course_name"));
            target.course_Description = dataReader.GetString(dataReader.GetOrdinal("course_Description"));

            return target;
        }

    }
}
