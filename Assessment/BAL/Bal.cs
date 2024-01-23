using BusinessObject.Model;
using DAL;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

namespace BAL
{
    public class Bal
    {

        Dal dal = new Dal ();

        public int addUser(User user)
        {
            dal.AddUser(user);
            return 0;
        }

        public Role GetRole(string rolename)
        {
           return  dal.GetRole(rolename);
            
        }

        public User GetUser(String user)
        {
            return dal.GetUser(user);
        }

        public int AddProduct(Product product)
        {
            dal.AddProduct(product);
            return 0;
        }


    }
}