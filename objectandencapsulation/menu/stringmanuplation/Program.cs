using System;

namespace stringmanuplation
{
    public class fighter
    {
        // instance variables
        private int pStrength;
        private int pSnowballs;
        private string pName;

        //properties
        public int strength
        {
            get
            {
                return pStrength;
            }
            set
            {
                pStrength = value;
            }
        }

        public int snowballs
        {
            get
            {
                return pStrength;
            }
            set
            {
                pStrength = value;
            }
        }
        public string name
        {
            get
            {
                return pName;
            }
            set
            {
                pName = value;
            }
        }

        //constructor
        public fighter(string theName)
        {
            //initlize
            strength = 3;
            snowballs = 3;
            name = theName;
        }
        public bool throwSnow(int range)
        {
            bool hit = false;
            int myRoll;
            Random roller = new Random();
            if (snowballs <= 0)
            {
                Console.WriteLine("{0} is out of snowballs",name);
            }
            else
            {
                myRoll = roller.Next(10);
                if (myRoll > range)
                {
                    hit = true;
                }
                snowballs--;
            }
            return hit;

        }
    }
    //robo fighter class
    public class roboFighter : fighter
    {
        private fighter player;
        public roboFighter(fighter thePlayer, string theName) : base(theName)
        {
            player = thePlayer;
        }
        public int choosePlay(int range)
        {
            int thePlay;
            Random roller = new Random();
            if(snowballs <= 0)
            {
                Console.WriteLine(name + "making a snowball");
            }
            else
            {
                thePlay = roller.Next(6);
                switch (thePlay)
                {
                    case 0:
                        Console.WriteLine("{0} moves closer.", name);
                        range--;
                        break;
                    case 1:
                        Console.WriteLine("{0} backs away.",name);
                        range++;
                        break;
                    case 2:
                        Console.WriteLine(name +"is making snow balls");
                        snowballs++;
                        break;
                    default:
                        Console.WriteLine("{0} throws a snowball", name);
                        if (throwSnow(range))
                        {
                            Console.WriteLine("{0} has been hit", player.name);
                            player.strength--;
                        }
                        else
                        {
                            Console.WriteLine("{0} missed you",name);
                        }
                        break; 
                }
            }
            return range;
        }

    }

    // class main menu
    class mainmenu
    {
        int range;
        fighter player;
        roboFighter opponent;
        bool keepgoing = true;

        public mainmenu()
        {
            int choice;
            string name;
            Console.Write("what is your name");
            name = Console.ReadLine();
            player = new fighter(name);
            Console.Write("What is your oppoinent name");
            name = Console.ReadLine();
            opponent = new roboFighter(player, name);
            range = 10;
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            mainmenu mm = new mainmenu();
            while (keepGoing)
            {
                choice = displayMenu();
                switch (choice)
                {
                    case 0:
                        //quit
                        Console.WriteLine("quitting");
                        keepGoing = false;
                        break;
                    case 1:
                        //make a snowball
                        player.snowballs++;
                        break;
                    case 2:
                        range−−;
                        if (range < 0)
                        {
                            range = 0;
                        } // end if
                        break;
                    case 3:
                        range++;
                        break;
                    case 4:
                        if (player.throwSnow(range))
                        {
                            Console.WriteLine("You hit {0}", opponent.name);
                            opponent.strength−−;
                        }
                        else
                        {
                            Console.WriteLine("You missed {0}", opponent.name);
                        } // end if
                        break;
                    default:
                        Console.WriteLine("you said {0}", choice);
                        break;
                } // end switch
                range = opponent.choosePlay(range);
                checkWinner();
            } // end while loop
        } // end constructor

    }

        }
    }
