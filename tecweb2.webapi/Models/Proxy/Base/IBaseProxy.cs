using System.Collections.Generic;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Models.Proxy.Base
{
    public interface IBaseProxy<TProxy, TEntity> where TProxy : BaseProxy<TProxy, TEntity>, new() where TEntity : BaseEntity
    {
        TProxy EntityToProxy(TEntity entity);
        List<TProxy> EntityListToProxyList(List<TEntity> entityList);
    }
}