﻿using CackeBack.DAL.Dbcontext;
using CackeBack.DAL.Interface;
using CakeBack.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CackeBack.DAL.Repositories
{
    public class CatetoryRepository : IGenericRepository<Category>
    {

        private readonly CakeDbContext _dbContext;

        public CatetoryRepository(CakeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<bool> Insertar(Category modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Actualizar(Category modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }


        public Task<Category> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Category>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
