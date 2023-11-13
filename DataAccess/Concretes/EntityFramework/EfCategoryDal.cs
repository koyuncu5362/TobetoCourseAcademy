using DataAccess.Abstracts;
using Entities.Abstracts;
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
    public class EfCategoryDal : ICategoryDal
    {

        public void Add(Category entity)
        {
            using (KodlamaIoContext context = new KodlamaIoContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State=EntityState.Added;
                context.SaveChanges();
            }    
        }

        public void Delete(Category entity)
        {
            using (KodlamaIoContext context = new KodlamaIoContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Category Get(Expression<Func<Category,bool>> filter)
        {
            using (KodlamaIoContext context = new KodlamaIoContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);
            }
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            using (KodlamaIoContext context = new KodlamaIoContext())
            {
                return filter == null ? context.Set<Category>().ToList() : context.Set<Category>().Where(filter).ToList();
            }
        }

        public void Update(Category entity)
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
