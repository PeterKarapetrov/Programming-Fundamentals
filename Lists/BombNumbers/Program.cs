using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().
                                Split().
                                Select(int.Parse).
                                ToList();

            int[] bomb = Console.ReadLine().
                         Split().
                         Select(int.Parse).
                         ToArray();

            while (numList.Contains(bomb[0]))
            {
                Bomb(numList, bomb);
            }       

            int sum = numList.Sum();
            Console.WriteLine(sum);
        }

        static void Bomb(List<int> numList, int[] bomb)
        {
            int bombIndex = (numList.FindIndex(s => s == bomb[0]));

            int leftDamgeIndex = bombIndex - bomb[1];
            int rightDamageIndex = bombIndex + bomb[1];

            if (leftDamgeIndex >= 0 && rightDamageIndex <= numList.Count - 1)
            {
                int removeCount = rightDamageIndex - leftDamgeIndex + 1;
                numList.RemoveRange(leftDamgeIndex, removeCount);
            }
            else if (leftDamgeIndex < 0 && rightDamageIndex <= numList.Count - 1)
            {
                int removeCount = rightDamageIndex + 1;
                numList.RemoveRange(0, removeCount);
            }
            else if (leftDamgeIndex >= 0 && rightDamageIndex > numList.Count - 1)
            {
                int removeCount = numList.Count - leftDamgeIndex;
                numList.RemoveRange(leftDamgeIndex, removeCount);
            }
            else
            {
                numList.Clear();
            }
        }
    }
}
