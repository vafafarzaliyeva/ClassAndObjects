using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class User
    {
        private string _username;
        private string _password;



        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                

                if (value.Length >= 8)
                {
                  _username = value;
                }
                
                 
           
            }
        }
       
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {

                int countLower = 0;
                int countUpper = 0;
                int countDigit = 0;

                if (value.Length >= 8) { 
                foreach (char item in value)
                {
                    if (char.IsLower(item))
                    {
                        countLower++;
                    }
                    else if (char.IsUpper(item))
                    {
                        countUpper++;
                    }
                    else if (char.IsDigit(item))
                    {
                        countDigit++;
                    }

                }
                if (countLower >= 1 && countUpper >= 1 && countDigit >= 1)
                {
                    _password = value;

                  
                }
                }
            }

        }
       
       
        public User(string name)
        {
            _username = name;
        }
        





        
    }
}
