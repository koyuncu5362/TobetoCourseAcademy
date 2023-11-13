using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseInstructorService
    {
        List<CourseInstructor> GetAll();
        CourseInstructor GetById(int id);
        void Add(CourseInstructor courseInstructor);
        void Delete(CourseInstructor courseInstructor);
        void Update(CourseInstructor courseInstructor);
    }
}
