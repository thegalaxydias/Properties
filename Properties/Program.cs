using System;

namespace Properties
{


    public class User
    {



        private string login;
        private int password;
        private string role;

        public string country { get; set; }
        public int zipcode { get; set; } 


        public string Login
        {
            set
            {
                if (value.Length < 10)
                {
                    Console.WriteLine("Login can not be less than 10 symbols");
                   
                }
                else { login = value; Console.WriteLine("Login: " + Login);

                }
               
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
                password = value; Console.WriteLine("Password: " + Password);
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
                role = value; Console.WriteLine("Role: " + Role);
            }
        }

        public User(string l, string r, int p, string c, int z)
        {
            Login = l;
            Role = r;
            Password = p;
            country = c;
            zipcode = z;

        }


    }
    public class Program
    {
        static void Main(string[] args)
        {




            User tom = new User("j", "asd", 123, "USA", 666);

            Console.WriteLine("Country: " + tom.country);
            Console.WriteLine("ZipCode: "+ tom.zipcode);




        }



    }
}



