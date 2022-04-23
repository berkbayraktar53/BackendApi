using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Add(Category entity)
        {
            _categoryDal.Add(entity);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category entity)
        {
            _categoryDal.Delete(entity);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        //[SecuredOperation("Category.List,Admin")]
        [CacheAspect(duration: 10)]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(x => x.CategoryId == id));
        }

        //[SecuredOperation("Category.List,Admin")]
        //[CacheAspect(duration: 10)]
        [PerformanceAspect(interval: 5)]
        public IDataResult<List<Category>> GetList()
        {
            Thread.Sleep(5000);
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }

        public IResult Update(Category entity)
        {
            _categoryDal.Update(entity);
            return new SuccessResult(Messages.CategoryUpdated);
        }
    }
}