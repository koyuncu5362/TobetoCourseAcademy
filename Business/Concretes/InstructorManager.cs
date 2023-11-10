using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class InstructorManager
    {
        public void Add(Instructor instructor)
        {
            AdoNetInstructorDal adoNetInstructorDal= new AdoNetInstructorDal();
            adoNetInstructorDal.Add(instructor);
        }
    }
 
}
