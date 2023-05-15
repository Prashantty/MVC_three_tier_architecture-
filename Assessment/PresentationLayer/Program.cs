using BAL;
using BusinessObject.Model;
using System.Runtime.CompilerServices;

namespace PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ch;

            Console.WriteLine("Enter the Choice !!!");
            Console.WriteLine("1 . Admin");
            Console.WriteLine("2 . Supplier");
            Console.WriteLine("3 . Customer");
            ch = int.Parse(Console.ReadLine());
            Program program = new Program();

            switch (ch)
            {

                case 1:
                    program.AdminWorks();

                    break;
                case 2:

                    // program.SupplierWorks();
                    break;
                case 3:

                    //program.CustomerWorks();
                    break;
                default:
                    Console.WriteLine("invalid Input !!!");
                    break;
            }


        }

        public void AdminWorks()
        {
            int ch;

            try
            {
                while (true)
                {
                    Console.WriteLine("Enter the chioce");
                    Console.WriteLine("1 . Add users");
                    Console.WriteLine("2 . Delete Users");
                    ch = int.Parse(Console.ReadLine());
                    Program program1 = new Program();
                    switch (ch)
                    {
                        case 1:
                            program1.Addusers();

                            break;
                        case 2:

                            program1.DeleteUsers();
                            break;
                        default:
                            Console.WriteLine("Enter th valid options");
                            break;
                    }

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); Console.WriteLine("Enter the valid input !!!"); }

        }

        public void Addusers()
        {
            int ch;
            Console.WriteLine("Add Users");
            Console.WriteLine("1 . Add Supplier");
            Console.WriteLine("2 . Add Customer");
            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Bal bal = new Bal();
                    Console.WriteLine("--Supplier--");
                    Console.WriteLine("Enter the Name ::");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the Date Created :::");
                    DateTime createdate = DateTime.Now;
                    Console.WriteLine("IsActive:: ");
                    bool isactive = true;

                    string username = "Supplier";

                    Role role = bal.GetRole(username);


                    User user = new User()
                    {
                        Name = name,
                        DateCreated = createdate,
                        IsActive = isactive,
                        Role = role
                        
                    };
                   
                    int resp = bal.addUser(user);
                    if(resp == 0)
                    {
                        Console.WriteLine("Record Added");
                    }

                    break;
                case 2:

                    Bal bal1 = new Bal();
                    Console.WriteLine("--Customers--");
                    Console.WriteLine("Enter the Name ::");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Enter the Date Created :::");
                    DateTime createdate1 = DateTime.Now;
                    Console.WriteLine("IsActive:: ");
                    bool isactive1 = true;
                    string username1 = "Customer";



                    User user1 = new User()
                    {
                        Name = name1,
                        DateCreated = createdate1,
                        IsActive = isactive1
                    };

                    Role role1 = bal1.GetRole(username1);
                    int resp1 = bal1.addUser(user1);

                    break;
                default:
                    Console.WriteLine("Enter th valid options");
                    break;
            }


        }

        public void DeleteUsers()
        {
            int ch;
            Console.WriteLine("Delete Users");
            Console.WriteLine("1 . Delete Supplier");
            Console.WriteLine("2 . Delete Customer");
            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:


                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Enter th valid options");
                    break;
            }


        }





    }
}