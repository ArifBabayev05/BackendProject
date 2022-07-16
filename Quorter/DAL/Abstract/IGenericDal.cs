using System;
using System.Collections.Generic;

namespace DAL.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);

        List<T> GetList();
    }
}

