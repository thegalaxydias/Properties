using System;

namespace Properties
{


    public class User
    {



        private string login;
        private int password;
        private string role;

       
        public string Login
        {
            set
            {
                if (login.Length < 10)
                {
                    Console.WriteLine("Login can not be less than 10 symbols");
                }
                else { login = value; }
            }

            get
            {
                return login;
            }
        }

        public int Password
        {
            get
            {
                return password;
            }


            set
            {
                password = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }


            set
            {
                role = value;
            }
        }

        public User (string l, string r,  int p)
            {
            l = Login;
            r = Role;
            p = Password;

            }


        public void description()
        {

            {
               

                Console.WriteLine($"Role: { Login} \nLogin: { Role} \nPassword: { Password}");
            }


        }
    }
    public class Program
    {
        static void Main(string[] args)
        {



            ////Console.Write("Enter login: ");
            ////string login = Console.ReadLine();
            ////Console.Write("Enter role: ");
            ////string role = Console.ReadLine();
            ////Console.Write("Enter password: ");
            ////int password = Convert.ToInt32(Console.ReadLine());

            //Console.ReadKey();

            User tom = new User("asd","asd", 123);               
            tom.description();
           

        }

       

    } 
}

        

