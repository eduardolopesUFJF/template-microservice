﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MicroServiceBase.Domain.UsuarioRoot.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity BuscarPorId(int id);
        ICollection<TEntity> BuscarTodos();
        ICollection<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);

        void Update(TEntity t);
        void UpdateCompose(TEntity entity, object[] chaves);
    }
}
