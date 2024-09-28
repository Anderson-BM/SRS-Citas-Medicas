
using CitasMedicaApp.Domain.Result;
using System.Linq.Expressions;

namespace CitasMedicaApp.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {


        Task<OperationRessult> Save(TEntity entity);

        Task<OperationRessult> Update(TEntity entity);

        Task<OperationRessult> Remove(TEntity entity);

        List<OperationRessult> GettAll();

        Task<OperationRessult> GetEntityBy(int Id);

        Task<OperationRessult> Exists(Expression<Func<TEntity, bool>> filter);



    }
}
