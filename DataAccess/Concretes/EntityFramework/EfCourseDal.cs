using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal :EfEntityRepositoryBase<Course,KodlamaIoContext>,ICourseDal
    {
      

        public List<CourseDetail> GetDetails()
        {
            using (KodlamaIoContext context = new KodlamaIoContext())
            {
                var result = from courses in context.Course
                             join categories in context.Category
                             on courses.CategoryId equals categories.Id
                             select new CourseDetail
                             {
                                 CategoryName = categories.Name,
                                 CourseDescription = courses.Description,
                                 CourseImage = courses.ImageUrl,
                                 CoursePrice = courses.Price,
                                 CourseName = courses.Name,
                                 InstructorName = "ss"
                             };
                return result.ToList();

            }
        }

      
    }
}
