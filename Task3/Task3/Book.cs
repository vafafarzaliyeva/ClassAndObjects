using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Book
    {
        public string _name;
        public int _pagecount;

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _name = value;
                }

            } 
        }

        public int PageCount {
            get
            {
                return _pagecount;
            }

            set
            {
                if (value >= 10)
                {
                    _pagecount = value;

                }
            }
        }












        public Book(string name,int count)
        {
            Name = name;
            PageCount = count;
        }
    }
}
