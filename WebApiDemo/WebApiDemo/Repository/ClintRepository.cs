using WebApiDemo.Context;
using WebApiDemo.Interface;
using WebApiDemo.Model;

namespace WebApiDemo.Repository
{
    public class ClintRepository : ClintInterface
    {
        WebDbContext _db;
        public ClintRepository(WebDbContext db)
        {
            _db = db;
        }
        public void CreateClint(Clint clint)
        {
            _db.Clints.Add(clint);
            _db.SaveChanges(); 
        
        }

        public void DeleteClint(int id)
        {
           Clint clint = _db.Clints.SingleOrDefault(cl => cl.Id == id); 
            if(clint != null)
            {
                _db.Clints.Remove(clint);
                _db.SaveChanges();
            }

        }

        public void EditClint(int id, Clint clint)
        {
            throw new NotImplementedException();
        }

        public List<Clint> GetClint()
        {
            return _db.Clints.ToList();
        }

        public Clint GetClintById(int id)
        {
            return _db.Clints.FirstOrDefault(x => x.Id == id);
        }

     
    }
}
