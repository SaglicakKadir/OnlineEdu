﻿using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Concrete
{
    public class CourseCategoryManager : GenericManager<CourseCategory>, ICourseCategoryService
    {
        private readonly ICourseCategoryRepository _courseCategoryRepository;
        public CourseCategoryManager(IRepository<CourseCategory> _repsitory,ICourseCategoryRepository courseCategoryRepository) : base(_repsitory)
        {
            _courseCategoryRepository=courseCategoryRepository;
        }

        public void TDontShowOnHome(int id)
        {
            _courseCategoryRepository.DontShowOnHome(id);
        }

        public void TShowOnHome(int id)
        {
            _courseCategoryRepository.ShowOnHome(id);
        }
    }
}