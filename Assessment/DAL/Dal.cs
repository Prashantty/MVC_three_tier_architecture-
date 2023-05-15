using BusinessObject.Model;
using DAL.Context;

namespace DAL
{
    public class Dal
    {

        ShoppingDbContext db = new ShoppingDbContext();


        public int AddUser(User user)
        {
            db.Users.Add(user); 
            db.SaveChanges();
            return 0;
        }

        public Role GetRole(string rolename)
        {
            return (db.Roles.FirstOrDefault( x => x.UserName == rolename ));
        }
    }
}