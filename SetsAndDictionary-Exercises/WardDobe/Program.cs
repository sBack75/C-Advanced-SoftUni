using System;
using System.Collections.Generic;
using System.Linq;

namespace WardDobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();


            for (int i = 0; i < howMany; i++)
            {
                string[] curData = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string clothesType = curData[0];
                string[] curClothes = curData[1].
                    Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!clothes.ContainsKey(clothesType))
                {
                    clothes.Add(clothesType, new Dictionary<string, int>());

                    for (int s = 0; s < curClothes.Length; s++)
                    {
                        clothes[clothesType].Add(curClothes[s], +1);
                    }
                }
                else
                {
                    for (int s = 0; s < curClothes.Length; s++)
                    {
                        if (clothes.ContainsKey(clothesType) && clothes[clothesType].ContainsKey(curClothes[s]))
                        {
                            clothes[clothesType][curClothes[s]] += +1;
                        }
                        else
                        {
                            clothes[clothesType].Add(curClothes[s], +1);

                        }
                    }
                }
            }

            string[] searchClothes = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string searchType = searchClothes[0];
            string searchDress = searchClothes[1];

            foreach (var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var secondItem in item.Value)
                {
                    if (item.Key == searchType && secondItem.Key == searchDress)
                    {
                        Console.WriteLine($"* {secondItem.Key} - {secondItem.Value} (found)");
                    }
                    else
                    {
                        Console.WriteLine($"* {secondItem.Key} - {secondItem.Value}");

                    }
                }
            }
        }
    }
}
