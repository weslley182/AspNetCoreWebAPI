using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly SmartContext _context;
        public Repository(SmartContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : Entidade
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : Entidade
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : Entidade
        {
            _context.Remove(entity);
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}