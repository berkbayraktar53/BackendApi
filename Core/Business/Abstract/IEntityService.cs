using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Abstract
{
    public interface IEntityService<T>
    {
        IDataResult<List<T>> GetList();
        IDataResult<T> GetById(int id);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}