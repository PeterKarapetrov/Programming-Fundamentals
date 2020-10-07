using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int mSkip = nums[0];
            int nTake = nums[1];

            string inputLine = Console.ReadLine();
            string pattern = @"\|<([\w]{" + mSkip + "})" + @"([\w]{0," + nTake + "})";

            string[] matched = Regex.Matches(inputLine, pattern).Cast<Match>().Select(a => a.Groups[2].Value).ToArray();

            Console.WriteLine(string.Join(", ", matched));
        }
    }
}
