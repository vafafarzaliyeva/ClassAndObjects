using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Book book = new Book("Flowers for Algernon",100);
            string [] Book = new string[3];
            int elementsayi = 0;

            while (true)
            {
                int i = 0; 
                Console.WriteLine("Kitab adini daxil edin :");
                string kitabadi = Console.ReadLine();
                book.Name = kitabadi;
                Console.WriteLine("Sehife sayini daxil edin");
                string a = Console.ReadLine();
                int say = int.Parse(a);
                book.PageCount = say; 

                if(book.PageCount==say && book.Name == kitabadi)
                {
                    Book[i] = kitabadi +" "+ say;
                    i++;
                    elementsayi++;
                    if (elementsayi == Book.Length)
                    {
                        break;
              
                    }

                   
                
                    
              
                }
                else
                {
                    Console.WriteLine("Kriteriyalari desteklemir");
                    
                   
                }
                
            }
            foreach (string item in Book)
                {
                Console.WriteLine(item);
                }

               
            }

           
            
        
                
               
                   


                }
            


        }
    

