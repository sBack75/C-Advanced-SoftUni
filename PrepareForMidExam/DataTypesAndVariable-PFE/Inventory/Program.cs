using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstItemsAdd = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> items = new List<string>(firstItemsAdd);
            

            while (true)
            {
                string[] curComand = Console.ReadLine()
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (curComand[0] == "Craft!")
                {
                    break;
                }
                if (curComand[0] == "Collect")
                {
                    string newItem = curComand[1];
                    items = Collect(items, newItem);
                }
                else if (curComand[0] == "Drop")
                {
                    string drobItem = curComand[1];
                    items = Drob(items, drobItem);
                }
                else if (curComand[0] == "Combine Items")
                {
                    string[]itemsForCombine = curComand[1].Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string oldItem = itemsForCombine[0];
                    string newItem = itemsForCombine[1];
                    items = Combine(items, oldItem, newItem);
                }
                else if (curComand[0] == "Renew")
                {
                    string renewItem = curComand[1];
                    items = Renew(items, renewItem);
                }
                
            }

            Console.WriteLine(string.Join(", ",items));
        }
        static List<string> Collect(List<String> items , string newItem)
        {
            if (items.Contains(newItem))
            {
                return items;
            }
            else
            {
                items.Add(newItem);
                return items;
            }
            return items;

        }
        static List<string> Drob (List<string> items , string drobItem)
        {
            items.Remove(drobItem);
            return items;
        }
        static List<string> Combine(List<string> items,string oldItem , string newItem)
        {
            if (items.Contains(oldItem))
            {
                 int index = items.IndexOf(oldItem)+1;
                items.Insert(index, newItem);
                return items;
            }
            else
            {
                return items;
            }
           
        }
        static List<string> Renew(List<string>items , string renewItem)
        {
            if (items.Contains(renewItem))
            {
                int index = items.IndexOf(renewItem);
                items.Add(renewItem);
                items.RemoveAt(index);
                return items;
            }
            else
            {
                return items;
            }
        }
        
    }
}
