using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCCDS.Csharp.Dominio.Interfaces.Servico
{
    public interface IServicoBase<TEntity> where TEntity : class
    { 
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Dispose();
    }
}
