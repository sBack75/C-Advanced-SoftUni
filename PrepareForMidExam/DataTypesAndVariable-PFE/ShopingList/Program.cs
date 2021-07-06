using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> products = new List<string>(data);


            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "Go" && command[1] == "Shopping!")
                {
                    break;
                }
                string curInstruct = command[0];

                if (curInstruct == "Urgent")
                {
                    string item = command[1];
                    products = Urgent(products, item);
                }
                else if (curInstruct == "Unnecessary")
                {
                    string item = command[1];
                    products = Remove(products, item);
                }
                else if (curInstruct == "Correct")
                {
                    string oldItem = command[1];
                    string newItem = command[2];
                    products = Correct(products, oldItem, newItem);
                }
                else if (curInstruct == "Rearrange")
                {
                    string item = command[1];
                    products = Rearrange(products, item);
                }
                
            }
            
            Console.WriteLine(string.Join(", ",products));

        }
        static List<string> Urgent (List<string> products , string itemName)
        {
            if (!products.Contains(itemName))
            {
                products.Insert(0,itemName);
                return products;
            }
            else
            {
                return products;
            }
        }
        static List<string> Remove (List<string>products , string itemName)
        {
            if (products.Contains(itemName))
            {
                products.Remove(itemName);
                return products;
            }
            else
            {
                return products;
            }
        }
        static List<string> Correct(List<string> products, string oldItem , string newItem)
        {
            if (products.Contains(oldItem))
            {
                int index = products.IndexOf(oldItem);
                products[index] = newItem;
                return products;
            }
            else
            {
                return products;
            }
        }
        static List<string> Rearrange(List<string> products , string item)
        {
            if (products.Contains(item))
            {
                int index = products.IndexOf(item);
                products.RemoveAt(index);
                products.Add(item);
                return products;
            }
            else
            {
                return products;
            }
        }
    }
}
