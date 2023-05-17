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


        public Role GetRole(String rolename)
        {
            return (db.Roles.FirstOrDefault( x => x.UserName == rolename ));
        }

        public User GetUser(String username)
        {
            return db.Users.FirstOrDefault( x => x.Name == username );  
        }

        public int AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return 0;
        }
    }
}