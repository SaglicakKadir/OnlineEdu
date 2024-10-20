using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Concrete
{
    public class GenericManager<T>(IRepository<T> _repsitory) : IGenericService<T> where T : class
    {
        public int TCount()
        {
            return _repsitory.Count();
        }

        public void TCreate(T entity)
        {
             _repsitory.Create(entity); 
        }

        public void TDelete(int id)
        {
            _repsitory.Delete(id);
        }

        public int TFilteredCount(Expression<Func<T, bool>> predicate)
        {
            return _repsitory.FilteredCount(predicate);
        }

        public T TGetByFilter(Expression<Func<T, bool>> predicate)
        {
            return _repsitory.GetByFilter(predicate);
        }

        public T TGetById(int id)
        {
            return _repsitory.GetById(id);
        }

        public List<T> TGetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return _repsitory.GetFilteredList(predicate);
        }

        public List<T> TGetList()
        {
            return _repsitory.GetList();
        }

        public void TUpdate(T entity)
        {
            _repsitory.Update(entity);
        }
    }
}
