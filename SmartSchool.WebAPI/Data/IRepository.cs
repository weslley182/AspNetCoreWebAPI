using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : Entidade;
        void Update<T>(T entity)  where T : Entidade;
        void Delete<T>(T entity)  where T : Entidade;
        bool SaveChanges();
    }
}