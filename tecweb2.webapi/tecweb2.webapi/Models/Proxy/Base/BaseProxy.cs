using System;
using System.Collections.Generic;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Models.Proxy.Base
{
    public abstract class BaseProxy<TProxy, TEntity> : IBaseProxy<TProxy, TEntity> where TEntity : BaseEntity
        where TProxy : BaseProxy<TProxy, TEntity>, new()
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }

        public abstract TProxy EntityToProxy(TEntity entity);

        protected TProxy Init(TEntity entity)
        {
            var proxy = new TProxy();
            
            proxy.Id = entity.Id;
            proxy.Active = entity.Active;
            
            return proxy;
        }


        public virtual List<TProxy> EntityListToProxyList(List<TEntity> entityList)
        {
            var list = new List<TProxy>();

            foreach (var entity in entityList)
            {
                list.Add(EntityToProxy(entity));
            }

            return list;
        }
    }
}