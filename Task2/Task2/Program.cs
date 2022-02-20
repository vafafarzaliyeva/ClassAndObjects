using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mehsul adi yazin");
            Product product1 = new Product("Milla");
          

            product1.TotalIncome = 0;
            product1.Count = 10;
            product1.Price = 4;

      

            while (product1.Count>=1)
            {
            string ad = Console.ReadLine();

                if (ad == product1.Name)
                {
                    while (true) { 
                    Console.WriteLine($"Mehsuldan {product1.Count} ededdir.Nece eded satmaq isteyirsiniz ?");
                    string a = Console.ReadLine();
                    int say = int.Parse(a);
                    Console.WriteLine($"Satildi.Umumi gelir = {product1.Sell(say)}"); 
                        
                    Console.WriteLine("Yene satmaq isteyirsinizmi? y/n");
                    string b = Console.ReadLine();

                       if (b == "y")
                       {
                           if (product1.Count == 1)
                           {
                            Console.WriteLine("Son mehsulu da satmaq isteyirsinizmi? y/n");
                            string c = Console.ReadLine();

                                   if (c == "y")
                                   {
                                     Console.WriteLine($"{product1.Sell(say)}");
                                     break;

                               
                                   }
                           else
                           {
                           break;
                           }
                       }
                       else
                       {
                         break;
                       }
                           
                            
                          
                        }
                            else Console.WriteLine("Mehsuldan qalmayib");
                            break;
                          
                  
                       
                    }
                    
;
                }
                else Console.WriteLine("Bele bir mehsul yoxdur");
                
            }

            



        }
    }
}
