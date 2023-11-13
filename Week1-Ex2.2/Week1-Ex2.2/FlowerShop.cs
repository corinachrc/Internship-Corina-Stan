using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Week1_Ex2._2
{
    internal class FlowerShop
    {
       // List to store available products in the flower shop
        public  List<Product> listOfProducts=new List<Product>();

        // List to store cash receipts for sales transactions
        public List<CashReceipt> cashReceipts = new List<CashReceipt>();


        // Method to initiate a new sale and create a new cash receipt
        public List<CashReceipt> NewSale() 
        {
            CashReceipt cashReceipt = new CashReceipt();            
            cashReceipts.Add(cashReceipt);
            cashReceipt.CashReceiptNumber = cashReceipts.Count;
            return cashReceipts;
        }

        // Method to add a product and its quantity to the current cash receipt
        public List<CashReceipt> AddProductOnCashReceipt(Product product, int pieces)
        {
            if (listOfProducts.Contains(product))
            {
                cashReceipts[cashReceipts.Count() - 1].AddSaleToReceipt(product, pieces);
            }
            
            return cashReceipts;
        }

        // Method to display details of all cash receipts
        public void DisplayCashReceipts(int month)
        {
            foreach(CashReceipt cashReceipt in cashReceipts) {
                if (cashReceipt.CashReceiptDate.Month ==month)
                {
                    Console.WriteLine("------------------------");
                    cashReceipt.DisplayDetailsAboutCashReceipt();
                    Console.WriteLine("------------------------");
                }
            }
        }

        // Method to calculate and display total sales and product quantities
        public void CalculateAndDisplayTotalSales(int month)
        {
            int totalCash = 0;
            int rosesSold = 0;
            int gladiolusSold = 0;
            int hydrangeasSold = 0;
            int smallBouquetsSold = 0;
            int mediumBouquetsSold = 0;
            int bigBouquetsSold = 0;
            
            
            foreach (CashReceipt receipt in  cashReceipts)
            {
                if (receipt.CashReceiptDate.Month == month)
                {
                    
                    foreach (Product prod in receipt.pozitii.Keys)
                    {
                        switch (prod.Name)
                        {
                            case "rose":
                                rosesSold += receipt.pozitii[prod];
                                break;
                            case "gladiola":
                                gladiolusSold += receipt.pozitii[prod];
                                break;
                            case "hydrangea":
                                hydrangeasSold += receipt.pozitii[prod];
                                break;
                            case "smallBouquet":
                                smallBouquetsSold += receipt.pozitii[prod];
                                break;
                            case "mediumBouquet":
                                mediumBouquetsSold += receipt.pozitii[prod];
                                break;
                            case "bigBouquet":
                                bigBouquetsSold += receipt.pozitii[prod];
                                break;
                        }
                    }
                    
                    totalCash += receipt.TotalValue;
                    
                }
            }
            Console.WriteLine("==================================");
            Console.WriteLine("TOTAL SALES FOR MONTH: "+month);
            Console.WriteLine("Roses sold: "+rosesSold+" pieces");
            Console.WriteLine("Gladiolus sold: " + gladiolusSold + " pieces");
            Console.WriteLine("Hydrangeas sold: " + hydrangeasSold + " pieces");
            Console.WriteLine("Big bouquets sold: " + bigBouquetsSold + " pieces");
            Console.WriteLine("Medium bouquets sold: " + mediumBouquetsSold + " pieces");
            Console.WriteLine("Small bouquets sold: " + smallBouquetsSold + " pieces");
            Console.WriteLine("Total cash: "+totalCash+" RON");
        }
    }
}
