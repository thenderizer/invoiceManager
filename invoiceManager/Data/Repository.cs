namespace invoiceManager.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _context;

        public Repository(DataContext context) 
        {
            _context=context;
        }

        public IQueryable<T> table => _context.Set<T>();

        public void Create(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool SaveChanges()
        {
           return _context.SaveChanges()>0;
        }

        public void Update(T entity)
        {
        }
    }
}
