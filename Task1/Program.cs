using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Istifadeci adinizi teyin edin");
            User user = new User("Vefa");
           
           
            while (true)
            {
                string a = Console.ReadLine();
                
                user.Username = a;
                if (user.Username == a)
                {
                   
                    Console.WriteLine("Sifrenizi teyin edin");
                    while (true)
                    {
                        string b = Console.ReadLine();
                        user.Password = b;

                        if (user.Password == b)
                        {
                            Console.WriteLine("Qeydiyyat ugurla basa catdi");
                            break;
                        }
                        
                        else
                        {
                            Console.WriteLine("Duzgun sifre daxil edin.Minumum 8simvoldan ibaret olsun. 1 boyuk simvol , 1 kicik simvol ve 1 reqem olmalidir");
                        }
                    }
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Minumum 8 simvoldan ibaret istifadeci adi daxil edin");
                }
                
            }

       
         
           


           

           
            
           
         

           
        }
    }
}
