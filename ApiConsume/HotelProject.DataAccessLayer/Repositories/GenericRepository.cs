using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;

namespace HotelProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        } 

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            var value = _context.Set<T>().Find(id);
            return value;
        }

        public List<T> GetList()
        {
            var values = _context.Set<T>().ToList();
            return values;
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges(); 
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
