using System;
using System.Linq;
using System.Threading;

namespace Week1_Ex2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlowerShop flowerShop = new FlowerShop();
            Flower rose = new Flower("rose");
            flowerShop.listOfProducts.Add(rose);
            Flower gladiola = new Flower("gladiola");
            flowerShop.listOfProducts.Add(gladiola);
            Flower hydrangea = new Flower("hydrangea");
            flowerShop.listOfProducts.Add(hydrangea);
            Bouquet bigBouquet = new Bouquet("bigBouquet",[rose, gladiola, hydrangea], [9, 10, 3]);
            flowerShop.listOfProducts.Add(bigBouquet);
            Bouquet mediumBouquet = new Bouquet("mediumBouquet", [rose, gladiola], [6, 5]);
            flowerShop.listOfProducts.Add(mediumBouquet);
            Bouquet smallBouquet = new Bouquet("smallBouquet", [rose], [5]);
            flowerShop.listOfProducts.Add(smallBouquet);

            // Simulate sales for each day of the month
            for (int i = 0; i < 30; i++)
            {
               
                flowerShop.NewSale();

                // Modify the date and time for each cash receipt (simulation purpose only)
                flowerShop.cashReceipts.Last().CashReceiptDate=flowerShop.cashReceipts.Last().CashReceiptDate.AddDays(i);
                flowerShop.AddProductOnCashReceipt(rose, 15);
                flowerShop.AddProductOnCashReceipt(smallBouquet, 12);
                
                flowerShop.NewSale();
                flowerShop.cashReceipts.Last().CashReceiptDate = flowerShop.cashReceipts.Last().CashReceiptDate.AddDays(i).AddHours(1);
                flowerShop.AddProductOnCashReceipt(gladiola, 10);
                
                flowerShop.NewSale();
                flowerShop.cashReceipts.Last().CashReceiptDate = flowerShop.cashReceipts.Last().CashReceiptDate.AddDays(i).AddHours(2);
                flowerShop.AddProductOnCashReceipt(mediumBouquet, 10);
                flowerShop.AddProductOnCashReceipt(bigBouquet, 13);
                flowerShop.AddProductOnCashReceipt(hydrangea, 25);
            }
            

            flowerShop.DisplayCashReceipts(11);            
            flowerShop.CalculateAndDisplayTotalSales(11);
            

        }
    }
}
