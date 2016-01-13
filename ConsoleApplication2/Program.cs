using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context=new Context();

            var queryProduct = from pr in context.Products
                               where pr.Rate > 3
                               orderby pr.ProductName
                               select pr;


        }
    }
}
