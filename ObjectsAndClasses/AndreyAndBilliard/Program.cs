using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> priceList = new Dictionary<string, decimal>();
            int productsCount = int.Parse(Console.ReadLine());
            for (int count = 0; count < productsCount; count++)
            {
                List<string> inputProduct = Console.ReadLine().Split('-').ToList();

                string productName = inputProduct[0];
                decimal productPrice = decimal.Parse(inputProduct[1]);
                if (priceList.ContainsKey(productName) == false)
                {
                    priceList.Add(productName, productPrice);
                }
                else
                {
                    priceList[productName] = productPrice;
                }
            }

            SortedDictionary<string, Client> clientsOrdersD = new SortedDictionary<string, Client>();
            List<string> orderInput = Console.ReadLine().Split(new char[] { '-', ',' }).ToList();
            while (orderInput[0] != "end of clients")
            {
                
                if (priceList.ContainsKey(orderInput[1]) == false)
                {
                    orderInput = Console.ReadLine().Split(new char[] { '-', ',' }).ToList();
                    continue;
                }
                Client newClient = new Client();
                if (clientsOrdersD.ContainsKey(orderInput[0]) == false)
                {
                        newClient.Name = orderInput[0];
                        var newProductList = new Dictionary<string, int>();
                        newProductList[orderInput[1]] = int.Parse(orderInput[2]);
                        newClient.ShopList = newProductList;
                        newClient.Bill = 0;
                        clientsOrdersD[newClient.Name] = newClient;
                }
                else
                {
                    if (clientsOrdersD[orderInput[0]].ShopList.ContainsKey(orderInput[1]) == false)
                    {
                        clientsOrdersD[orderInput[0]].ShopList.Add(orderInput[1], int.Parse(orderInput[2]));
                    }
                    else
                    {
                        clientsOrdersD[orderInput[0]].ShopList[orderInput[1]] +=  int.Parse(orderInput[2]);
                    }
                }

                orderInput = Console.ReadLine().Split(new char[] { '-', ',' }).ToList();
            }

            foreach (var customer in clientsOrdersD)
            {
                Console.WriteLine($"{customer.Key}");
                customer.Value.SetClientBill(priceList);
                foreach (var pair in customer.Value.ShopList)
                {
                    Console.WriteLine($"-- {pair.Key} - {pair.Value}");

                }
                Console.WriteLine($"Bill: {customer.Value.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {clientsOrdersD.Values.Sum(x => x.Bill)}");
        }
    }

    class Client
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }

        public void SetClientBill(Dictionary<string, decimal> priceList)
        {
            foreach (var product in ShopList)
            {
                foreach (var pair in priceList)
                {
                    if (pair.Key == product.Key)
                    {
                        Bill += pair.Value * product.Value;
                    }
                }
            }
        }
        
    }
}
