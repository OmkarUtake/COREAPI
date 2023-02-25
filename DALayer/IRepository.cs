﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetBookById(int id);

        void AddBook(T book);
        void DeleteBook(int id);
        void UpdateBook(T model);
        void Save();

    }
}
