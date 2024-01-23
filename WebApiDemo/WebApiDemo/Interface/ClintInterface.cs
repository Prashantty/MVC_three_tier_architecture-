using WebApiDemo.Model;

namespace WebApiDemo.Interface
{
    public interface ClintInterface
    {
        public List<Clint> GetClint();
        public Clint GetClintById(int id);
        public void CreateClint(Clint clint);
        public void EditClint(int id , Clint clint);
        public void DeleteClint(int id);

    }
}
