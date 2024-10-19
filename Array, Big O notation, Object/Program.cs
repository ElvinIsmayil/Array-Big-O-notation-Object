using System.Diagnostics.CodeAnalysis;

namespace Array__Big_O_notation__Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            // 1. Verilmiş ededler siyahisindaki(int[]) en böyük ededi tapan alqoritm

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int greatNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > greatNumber)
                {
                    greatNumber = numbers[i];
                }
            }
            Console.WriteLine($"The greatest number is {greatNumber} ");

            #endregion

            #region Task2

            // Verilmiş Products arrayindəki Product objectlərinin Id'ləri tək olanlarının Price'larının ədədi ortasını tapan algorithm yazın.(Product objectinin propertyləri: Id(yeni reqem ve ya eded), Name, Price, StockCount)

            var product1 = new { Id = 1, Name = "Chips " ,   Price = 5,  StockCount = 15   };
            var product2 = new { Id = 2, Name = "Nuts"   ,   Price =  4, StockCount = 30   };
            var product3 = new { Id = 3, Name = "Chocolate", Price =  7, StockCount = 8   };
            var product4 = new { Id = 4, Name = "Honey" ,    Price = 10, StockCount = 50  };
            var product5 = new { Id = 5, Name = "Tea",       Price =  3, StockCount = 22   };

            var products = new[] { product1, product2,product3, product4, product5 };

            int sum = 0;
            int count = 0;
            int avarage = 0;


            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Id % 2 != 0)
                {
                   sum += products[i].Price;
                    count++;    
                }

            }

            avarage = sum / count;

            Console.WriteLine($"The avarage of three products with odd ids is {avarage} ");




            #endregion
        }
    }
}
        