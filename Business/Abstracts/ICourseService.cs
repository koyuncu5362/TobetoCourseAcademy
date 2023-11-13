using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        List<Course> GetAll();
        List<Course> GetAllByUnitPrice(double minValue,double maxValue);
        List<Course> GetByCategoryId(int categoryId);
        Course GetById(int id);
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);
        
    }
}
