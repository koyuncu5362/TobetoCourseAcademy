using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class InstructorManager:IInstructorService
    {
        IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.Get(p => p.Id == id);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

        
    }

}
