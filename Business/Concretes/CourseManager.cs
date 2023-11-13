﻿using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager:ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public List<Course> GetAllByUnitPrice(double minValue, double maxValue)
        {
            return _courseDal.GetAll(p => p.Price > minValue && p.Price < maxValue);
        }

        public List<Course> GetByCategoryId(int categoryId)
        {
            return _courseDal.GetAll(p => p.CategoryId==categoryId);
        }

        public Course GetById(int id)
        {
            return _courseDal.Get(p => p.Id == id);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
 
}
