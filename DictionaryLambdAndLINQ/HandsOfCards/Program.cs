using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] handInputString = Console.ReadLine().Split(':').ToArray();
            
            Dictionary<string, List<string>> playersWithHands = new Dictionary<string, List<string>>();

            while (handInputString[0] != "JOKER")
            {
                string playerName = handInputString[0];
                List<string> playerHand = handInputString[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (playersWithHands.ContainsKey(playerName) == false)
                {
                    playersWithHands[playerName] = playerHand;
                }
                else
                {
                    playersWithHands[playerName].AddRange(playerHand);
                }

                handInputString = Console.ReadLine().Split(':').ToArray();
            }

            foreach (var pair in playersWithHands)
            {
                int value = GetPlayerHandValue(pair.Value.ToArray());
                Console.WriteLine("{0}: {1}", pair.Key, value);
            }
        }
            static int GetPlayerHandValue(string[] playerHand)
            {
                int playerHandValue = 0;
                List<string> playerHandFinal = playerHand.Distinct().ToList();

                foreach (string card in playerHandFinal)
                {
                    int cardpower = 0;
                    int cardtype = 0;
                    char power = card[0];
                    char type = card[1];
                    if (power == '1')
                    {
                        type = card[2];
                    }

                    switch (power)
                    {
                        case '1':
                            cardpower = 10;
                            break;
                        case '2':
                            cardpower = 2;
                            break;
                        case '3':
                            cardpower = 3;
                            break;
                        case '4':
                            cardpower = 4;
                            break;
                        case '5':
                            cardpower = 5;
                            break;
                        case '6':
                            cardpower = 6;
                            break;
                        case '7':
                            cardpower = 7;
                            break;
                        case '8':
                            cardpower = 8;
                            break;
                        case '9':
                            cardpower = 9;
                            break;
                        case 'J':
                            cardpower = 11;
                            break;
                        case 'Q':
                            cardpower = 12;
                            break;
                        case 'K':
                            cardpower = 13;
                            break;
                        case 'A':
                            cardpower = 14;
                            break;
                    }

                    switch (type)
                    {
                        case 'S':
                            cardtype = 4;
                            break;
                        case 'H':
                            cardtype = 3;
                            break;
                        case 'D':
                            cardtype = 2;
                            break;
                        case 'C':
                            cardtype = 1;
                            break;
                    }

                    playerHandValue += cardpower * cardtype;

                }

                return playerHandValue;
            }
    }
}
