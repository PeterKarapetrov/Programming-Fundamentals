using System;
using System.Collections.Generic;
using System.Linq;

namespace SrabskoUnlished
{
    class Program
    {
        static void Main(string[] args)
        {
                Dictionary<string, Dictionary<string, int>> venue = new Dictionary<string, Dictionary<string, int>>();

                List<string> inputLine = Console.ReadLine().Split().ToList();

                while (inputLine[0] != "End")
                {
                    if (inputLine.Count < 4)
                    {
                       inputLine = Console.ReadLine().Split().ToList();
                       continue;
                    }

                    int ticketPrice;
                    int ticketCount;
                    int concertIncome;

                    if (int.TryParse(inputLine[inputLine.Count - 1], out ticketPrice) && int.TryParse(inputLine[inputLine.Count - 2], out ticketCount))
                    {
                        concertIncome = ticketPrice * ticketCount;
                        inputLine.RemoveRange(inputLine.Count - 2, 2);
                    }
                    else
                    {
                        inputLine = Console.ReadLine().Split().ToList();
                        continue;
                    }

                    int venueNamePositionIndex = 0;
                    int counter = 0;
                    for (int index = 0; index < inputLine.Count; index++)
                    {
                        if (inputLine[index].StartsWith("@"))
                        {
                            counter++;
                            venueNamePositionIndex = index;
                            break;
                        }
                    }
                    if (counter == 0)
                    {
                        inputLine = Console.ReadLine().Split().ToList();
                        continue;
                    }

                    List<string> venueNameList = inputLine.Skip(venueNamePositionIndex).ToList();
                    List<string> singerNameList = inputLine.Take(venueNamePositionIndex).ToList();
                    if (venueNameList.Count > 3 || singerNameList.Count > 3)
                    {
                        inputLine = Console.ReadLine().Split().ToList();
                        continue;
                    }
                    string venueName = string.Join(" ", venueNameList).Substring(1);
                    string singerName = string.Join(" ", singerNameList);

                    Dictionary<string, int> singer = new Dictionary<string, int>();

                    if (venue.ContainsKey(venueName) == false)
                    {
                        singer.Add(singerName, concertIncome);
                        venue.Add(venueName, singer);
                    }
                    else
                    {
                        if (venue[venueName].ContainsKey(singerName) == false)
                        {
                            venue[venueName].Add(singerName, concertIncome);
                        }
                        else
                        {
                            venue[venueName][singerName] += concertIncome;
                        }
                    }

                    inputLine = Console.ReadLine().Split().ToList();
                }

                foreach (var hall in venue)
                {
                    Console.WriteLine(hall.Key);
                    foreach (var pair in hall.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                    }
                }
        }
    }
}


