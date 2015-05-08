using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Services
{

    /// <summary>
    ///     員工資料維護的 Service.
    /// </summary>
    public interface Icourseservice
    {

        /// <summary>
        ///     新增course資料.
        /// </summary>
        /// <param name="employee">
        ///     課程資料.
        /// </param>
        void Addcourse(course course);   

        /// <summary>
        ///     取得所有課程資料.
        /// </summary>
        /// <returns>
        ///     所有課程資料.
        /// </returns>
        IList<course> GetAllcourse();

        /// <summary>
        ///     依據 ID 取得課程資料.
        /// </summary>
        /// <param name="id">
        ///     課程 Id.
        /// </param>
        /// <returns>
        ///     該課程資料.
        /// </returns>
        course GetcourseById(string course_id);

    }

}