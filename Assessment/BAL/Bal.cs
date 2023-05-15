using BusinessObject.Model;
using DAL;

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


    }
}