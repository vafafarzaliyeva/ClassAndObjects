using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Product
    {
        public string Name;
        public int Price;
        public int Count;
        public int TotalIncome;


        public int Sell(int say)
        {
            while (Count > 0)
            {
              
             Count = Count - say;
             TotalIncome += (Price * say);
             break;      
                
               
            }
           
            return TotalIncome; 
           


           

        }
        public Product(string name)
        {
            Name = name;
        }



    }
}

