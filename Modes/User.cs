using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHometask2.Modes
{
    public class User
    {
        private string UserName;

        private string Password;


        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }


        public string userName
        {
            get { return UserName; }
            set
            {
                if (userName.Length >= 8)
                {
                    UserName = value;
                }
                else
                {
                    Console.WriteLine("The length of the Username must be at least 8 !");
                }
            }
        }

        public string myPassword
        {
            get { return Password; }
            set
            {
                if (myPassword.Length >= 8)
                {
                    bool hasUpperCase = false;
                    bool hasLowerCase = false;
                    bool hasDigit = false;

                    foreach (char c in myPassword)
                    {
                        if (char.IsUpper(c))
                        {
                            hasUpperCase = true;
                        }
                        else if (char.IsLower(c))
                        {
                            hasLowerCase = true;
                        }
                        else if (char.IsDigit(c))
                        {
                            hasDigit = true;
                        }

                        if (hasUpperCase && hasLowerCase && hasDigit)
                        {
                            Password = value;
                        }
                        else
                        {
                            Console.WriteLine("The password does not meet the requirements !");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The length of the password must be at least 8 !");
                }

            }
        }



    }
}
