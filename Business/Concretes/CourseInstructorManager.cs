using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CourseInstructorManager : ICourseInstructorService
    {
        ICourseInstructorDal _courseInstructorDal;
        public CourseInstructorManager(ICourseInstructorDal courseInstructorDal)
        {
            _courseInstructorDal = courseInstructorDal;
        }
        public void Add(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Add(courseInstructor);
        }

        public void Delete(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Delete(courseInstructor);
        }

        public List<CourseInstructor> GetAll()
        {
           return _courseInstructorDal.GetAll();
        }

        public CourseInstructor GetById(int id)
        {
            return _courseInstructorDal.Get(p => p.Id == id);
        }

        public void Update(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Update(courseInstructor);
        }
    }

}
