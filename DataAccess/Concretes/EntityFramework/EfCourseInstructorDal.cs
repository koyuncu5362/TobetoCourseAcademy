using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseInstructorDal : ICourseInstructorDal
    {
        public void Add(CourseInstructor entity)
        {
            using (KodlamaIoContext context = new KodlamaIoContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(CourseInstructor entity)
        {
            using (KodlamaIoContext context = new KodlamaIoContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public CourseInstructor Get(Expression<Func<CourseInstructor, bool>> filter)
        {
            using (KodlamaIoContext context = new KodlamaIoContext())
            {
                return context.Set<CourseInstructor>().SingleOrDefault(filter);
            }
        }

        public List<CourseInstructor> GetAll(Expression<Func<CourseInstructor, bool>> filter = null)
        {
            using (KodlamaIoContext context = new KodlamaIoContext())
            {
                return filter == null ? context.Set<CourseInstructor>().ToList() : context.Set<CourseInstructor>().Where(filter).ToList();
            }
        }

        public void Update(CourseInstructor entity)
        {
            using (KodlamaIoContext context = new KodlamaIoContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
