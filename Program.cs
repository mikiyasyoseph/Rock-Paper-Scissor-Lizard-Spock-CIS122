/*Written by
     Mikiyas Yoseph
     Niftalem Kassa
     Tinsay Gebremariam
Last Mofified on 3/2/23*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPSSL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instantiatin objects
            Random random = new Random();
            Rock aRock = new Rock();
            Paper aPaper = new Paper();
            Scissor aScissor = new Scissor();
            Spock aSpock = new Spock();
            Lizard aLizard = new Lizard();

            //List of moves for ai player to generate random move
            List<string> aMoves = new List<string>() { "Rock", "Paper", "Scissor", "Spock", "Lizard"};
            
            //variables to track Scores
            int Pscore = 0;
            int Cscore = 0;

            
            while (true)
            {
                //checking if any of the player scores have reached 3 to end the game because it is first to 3
                if (Pscore == 3 || Cscore == 3)
                {
                    if (Pscore == 3)
                    {
                        Console.WriteLine("\tPlayer won\n");
                        Console.WriteLine("Player " + Pscore + "-" + Cscore + " Computer");
                    }
                    else
                    {
                        Console.WriteLine("Computer won");
                        Console.WriteLine("Player " + Pscore + "-" + Cscore + " Computer");
                    }
                    return;
                }

                Console.WriteLine("\n\tRock Paper Scissor Spock Lizard\n");
                Console.WriteLine("\tFIRST TO 3 WINS!\n");
                Console.WriteLine("Player " + Pscore + "-" + Cscore + " Computer" + "\n");
                
                //getting input
                Console.WriteLine("Enter your choice \n");
                string playerChoice = Console.ReadLine();//player move
                
                string computerChoice = aMoves[random.Next(aMoves.Count)];//computer move

                Console.WriteLine("player: " + playerChoice + "\n");
                Console.WriteLine("computer: " + computerChoice + "\n");

                //initial check to see if they have the same move to make it a tie
                if (playerChoice == computerChoice)
                {
                  
                    Console.WriteLine("\t\nTie\n");
                    continue;
                }
                
                //if player selects rock it will use the Rock object and the compare method inside it and passes computer
                //move as parameter
                if (playerChoice == "Rock")
                {
                    //display result from the compare method
                    Console.WriteLine("\t\nYou " + aRock.Compare(computerChoice));
                    
                    //give score to who won
                    if (aRock.Compare(computerChoice) == "Win")
                    {
                        Pscore += 1;
                    }
                    else
                    {
                        Cscore += 1;
                    }
                    //move to the next iteration
                    continue;
                }
                if (playerChoice == "Paper")
                {
                    Console.WriteLine("\t\nYou " + aPaper.Compare(computerChoice) + "\n");
                    if (aPaper.Compare(computerChoice) == "Win")
                    {
                        Pscore += 1;
                    }
                    else
                    {
                        Cscore += 1;
                    }
                    continue;
                }
                if (playerChoice == "Scissor")
                {
                    Console.WriteLine("\t\nYou " + aScissor.Compare(computerChoice) + "\n");
                    if (aScissor.Compare(computerChoice) == "Win")
                    {
                        Pscore += 1;
                    }
                    else
                    {
                        Cscore += 1;
                    }
                    continue;
                }
                if (playerChoice == "Spock")
                {
                    Console.WriteLine("\t\nYou " + aSpock.Compare(computerChoice) + "\n");
                    if (aSpock.Compare(computerChoice) == "Win")
                    {
                        Pscore += 1;
                    }
                    else
                    {
                        Cscore += 1;
                    }
                    continue;
                }
                if (playerChoice == "Lizard")
                {
                    Console.WriteLine("\t\nYou " + aLizard.Compare(computerChoice) + "\n");
                    if (aLizard.Compare(computerChoice) == "Win")
                    {
                        Pscore += 1;
                    }
                    else
                    {
                        Cscore += 1;
                    }
                    continue;
                }

            }
        }
    }
}
