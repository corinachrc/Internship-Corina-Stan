using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex2._2
{
    internal class CashReceipt
    {

        public DateTime CashReceiptDate { get;  set; }
        public int CashReceiptNumber {  get;  set; }

        // Dictionary to store products and their quantities in the cash receipt
        public Dictionary<Product, int> pozitii = new Dictionary<Product, int>();

        public int TotalValue {  get; private set; }
        public CashReceipt() {
           // CashReceiptDate = DateTime.Now;
            CashReceiptDate = new DateTime(2023,11,01,07,00,00);//folosita aceasta initializare pentru a putea simula toate zilele lunii
            pozitii.Clear();
            
        }

        // Method to add a sale to the cash receipt, updating the product quantities and total value
        public Dictionary<Product,int> AddSaleToReceipt(Product product, int pieces) { 
            pozitii.Add(product, pieces);
            TotalValue += product.Price * pieces;
            return pozitii;
        }

        // Method to display details about the cash receipt, including products, quantities, and total value
        public void DisplayDetailsAboutCashReceipt()
        {
            
            Console.WriteLine("Cash receipt no "+CashReceiptNumber+" / "+CashReceiptDate.ToString("dd.MM.yy hh:mm:ss"));
            foreach(Product item in pozitii.Keys)
            {

                Console.WriteLine(item.Name+"\t"+item.Price+ " RON \t*" + pozitii[item]+"\t"+ item.Price*pozitii[item]+" RON");
                
            }
            Console.WriteLine("Total value: "+TotalValue+" RON");
        }

        
    }
}
