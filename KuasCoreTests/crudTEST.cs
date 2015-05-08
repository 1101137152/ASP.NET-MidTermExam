using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudTEST
{
    [TestFixture]
    public class Class2test
    {
        string ID = "";

        [TestFixtureSetUp]
        public void Initial()
        {
            string sql = @"INSERT INTO [dbo].[course]([course_id],[course_name],[course_Description])
                             VALUES
                               (@course_id
                               ,@course_name
                                ,@course_Description);SELECT CAST(scope_identity() AS string);";
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString))
            {
                cn.Open();
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new SqlParameter("@course_id", "123test"));
                    cmd.Parameters.Add(new SqlParameter("@course_name", "JANE"));
                    cmd.Parameters.Add(new SqlParameter("@course_Description", "HelloWorld"));
                    ID = cmd.ExecuteScalar().ToString();

                    Console.WriteLine(ID);
                }
            }
        }

        [Test]
        public void TestAdd()
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString))
            {
                cn.Open();
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "select Max(course_id) from course";
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while ((dr.Read()))
                        {
                            Assert.AreEqual(ID, dr.GetSqlInt32(0).ToString());
                            break;
                        }
                        dr.Close();
                    }
                }
            }
        }
    }
}
