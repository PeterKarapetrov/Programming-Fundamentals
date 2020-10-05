using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliardII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> priceList = new Dictionary<string, decimal>();
            int productsCount = int.Parse(Console.ReadLine());
            for (int count = 0; count < productsCount; count++)
            {
                string[] inputProduct = Console.ReadLine().Split('-').ToArray();

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

            List<Client> clientsList = new List<Client>();
            string orderInput = Console.ReadLine();
            while (orderInput != "end of clients")
            {
                string[] clientOrder = orderInput.Split(new char[] { '-', ',' }, StringSplitOptions.None).ToArray();
                string clientName = clientOrder[0];
                string orderedProduct = clientOrder[1];
                int quantity = int.Parse(clientOrder[2]);

                if (priceList.ContainsKey(orderedProduct) == false)
                {
                    orderInput = Console.ReadLine();
                    continue;
                }
                else
                {
                    if (clientsList.Any(x => x.Name == clientName) == false)
                    {
                        Client newClient = new Client();
                        newClient.Name = clientName;
                        Dictionary<string, int> newShopingList = new Dictionary<string, int>();
                        newShopingList.Add(orderedProduct, quantity);
                        newClient.ShopList = newShopingList;
                        foreach (var product in priceList.Where(x => x.Key == orderedProduct))
                        {
                            newClient.Bill = quantity * product.Value;
                        }
                        clientsList.Add(newClient);
                    }
                    else if (clientsList.Any(x => x.Name == clientName) == true)
                    {
                            foreach (var client in clientsList.Where(x => x.Name == clientName))
                            {
                                if (client.ShopList.ContainsKey(orderedProduct) == false)
                                {
                                    client.ShopList.Add(orderedProduct, quantity);
                                    foreach (var product in priceList.Where(x => x.Key == orderedProduct))
                                    {
                                        client.Bill += product.Value * quantity;
                                    }
                                }
                                else
                                {
                                        foreach (var prod in priceList.Where(x => x.Key == orderedProduct))
                                        {
                                            client.ShopList[orderedProduct] += quantity;
                                            client.Bill += prod.Value * quantity;
                                        }
                                }
                            }
                    }
                }

                orderInput = Console.ReadLine();
            }

           
                foreach (var customer in clientsList.OrderBy(x => x.Name))
                {
                    Console.WriteLine(customer.Name);
                    foreach (var customerOrder in customer.ShopList)
                    {
                        Console.WriteLine($"-- {customerOrder.Key} - {customerOrder.Value}");
                    }
                    Console.WriteLine($"Bill: {customer.Bill:f2}");
                }
                Console.WriteLine($"Total bill: {clientsList.Sum(x => x.Bill):f2}");   
        }
    }

    class Client
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }
}
