using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager
    {
        public void Add(Course course)
        {
            AdoNetCourseDal courseDal = new AdoNetCourseDal();
            courseDal.Add(course);
        }
    }
 
}
