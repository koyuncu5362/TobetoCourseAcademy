using Business.Abstracts;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstracts;

using Entities.Concretes;
using Entities.Dto;


namespace Business.Concretes
{
    public class CourseManager:ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        [ValidationAspect(typeof(CourseValidator))]
        public IResult Add(Course course)
        {
            var result = BusinessRules.Run(CheckIfCourseCountOfCategoryCorrect(course.CategoryId));
            _courseDal.Add(course);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CategoryDeleted);
        }
        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.CategoriesListed);
        }

        public IDataResult<Course> GetById(int id)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(p => p.Id == id));
        }
        public IDataResult<List<CourseDetail>>  GetDetails()
        {
            if (DateTime.Now.Hour==17)
            {
                return new SuccessDataResult<List<CourseDetail>>(_courseDal.GetDetails());
            }
            return new ErrorDataResult<List<CourseDetail>>(Messages.ErrorMessage);
          
        }

        public IDataResult<List<Course>> GetAllByUnitPrice(double minValue, double maxValue)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p => p.Price>minValue &&p.Price<maxValue));
        }

        public IDataResult<List<Course>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p => p.CategoryId==categoryId));
        }


        private IResult CheckIfCourseCountOfCategoryCorrect(int categoryId)
        {
            var result = _courseDal.GetAll(p => p.CategoryId == categoryId).Count;
            if (result >= 15)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
    }
 
}
