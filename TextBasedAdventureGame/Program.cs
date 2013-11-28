using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextBasedAdventureGame
{
    class Program
    {        
        static void Main(string[] args)
        {
            bool playing = true;
            Game theGame = new Game();
            theGame.reset();
            while (playing == true)
            {
                theGame.checkIfValid(Console.ReadLine());
            }
        }
    }

    public class Game
    {
        bool atMill = false;
        bool beenHereWater = false;
        bool lookedAround = false;
        List<string> inventory = new List<string>();

        public void reset()
        {
            inventory.Add("EndOfInventory");

            beenHereWater = false;
            lookedAround = false;
            StartGame();
        }

        //EVERY action revolves from this statement
        public void checkIfValid(string toCheck)
        {
            whereTo(toCheck);

        }

        private void whereTo(string toHere)
        {
            switch (toHere)
            {
                case "Look around":
                case "look around":
                case "Look Around":
                case "look Around":
                    LookAround();
                    break;

                case "Test Inventory":
                case "test inventory":
                case "Test inventory":
                case "test Inventory":
                    testInventory();
                    break;

                case "Inventory":
                case "inventory":
                    printInventory();
                    break;

                case "Water":
                case "water":
                    Mill();
                    break;


                case "Field":
                case "field":
                    FieldOfShit();
                    break;

                case "River":
                case "river":
                    River();
                    break;

                case "Forest":
                case "forest":
                    Forest();
                    break;
            }
        }

        private void printInventory()
        {
            foreach (string inventoryItem in inventory)
            {
                Console.WriteLine(inventoryItem);
            }
        }

        private void Mill()
        {
            Console.Beep();
            foreach(string inventoryItem in inventory)
            {
                if (inventoryItem == "Rope")
                {
                    Console.WriteLine("You look around warily, fearing the rapids. You look around your bag for something to assist in crossing, and find a rope. It takes a coupld of tries, but you manage to hook the rope on a tough rock, and cross safely");
                    beenHereWater = true;
                    inventory.Remove("Rope");
                    return;
                }

                else
                {
                    continue;
                }
            }

            if (beenHereWater == true)
            {
                Console.WriteLine("Having been here already, you cockily attempt to traverse the rapids. Your quick steps lead to your downfall");
                reset();
            }

            else
            {
                Console.WriteLine("You gaze around in wonder. Having never seen such quick rapids before, so you take your time crossing. Unfortunately, taking your time means you were in the way when a tree came down, knocking you into the wtaer, where you freeze/drown/get clubbed by a tree to death.");
            }
        }

        private void testInventory()
        {
            for (int i = 0; i < 3; i++)
            {
                inventory.Add("Item " + i);
            }
        }

        private void inventoryFull(string itemToGet)
        {
            Console.WriteLine("Your inventory is full. You'll have to drop an item to pick up that " + itemToGet + ".");
            foreach (string inventoryItem in inventory)
            {
                Console.WriteLine(inventoryItem);
            }

            string thingToDrop = Console.ReadLine();

            foreach (string inventoryItem in inventory)
            {
                if (inventoryItem == thingToDrop)
                {
                    inventory.Remove(thingToDrop);
                    inventory.TrimExcess();
                }

                else
                {
                    continue;
                }
            }
        }

        private void LookAround()
        {
            if (lookedAround == false)
            {
                Console.WriteLine("You look around, and find a rope on the ground nearby!");
                foreach (string inventoryItem in inventory)
                {
                    if (inventoryItem == null)
                    {
                        
                        inventory.Add("Rope");
                        lookedAround = true;
                        return;
                    }

                    else if (inventoryItem == "EndOfInv")
                    {
                        inventoryFull("Rope");
                        lookedAround = true;
                        return;
                    }
                }
            }

            else
            {
                Console.WriteLine("You've already looked around.\n There is nothing interesting anymore");
            }
        }
        private void StartGame()
        {
            Console.Clear();
            Console.WriteLine("          Welcome to FAIL QUEST.\nThis text based adventure will test your failure awesomenessness.\n\nYou have just exited the TOWN of Shmagma, ");
            Console.WriteLine("it is a hot summer day with a nice cool wind blowing east and everything is\nperfect.");
            Console.WriteLine("All of a sudden a shriek comes from the north east of your position.\n");
            Console.WriteLine("Quickly you spin around and witness a massive DEMON carring a princess to the\ncastle behind the TOWN you just left.");
            Console.WriteLine("You feel you must do what you can to save the princess from her fate,\nbut you must aquire itams to aid you on your quest.\n");
            Console.WriteLine("you are facing a path that leads to a beautiful FIELD of tall grass.\n");
            Console.WriteLine("Behind you is the TOWN of Shmagma from which you have just exited.\n");
            Console.WriteLine("What do you choose to do?\n");
            Console.WriteLine("Go to the TOWN.");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
        }

        private void FieldOfShit()
        {
            Console.Clear();
            Console.WriteLine("As you approach the field you notice a fairly recognizable smell");
            Console.WriteLine("You realize it is the smell of feces, but you are unable to ");
            Console.WriteLine("Identify the origins of what it came from.");
            Console.WriteLine("To the east lies the RIVER,\nto the south, the MILL,\nand to the west is the FOREST.\n");
            Console.WriteLine("What do you choose to do?\n");
            Console.WriteLine("Go to the RIVER.");
            Console.WriteLine("Go to the MILL.");
            Console.WriteLine("Go to the FOREST.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
        }

        private void River()
        {
            Console.Clear();

            Console.WriteLine("You approach the river with caution as the rapids could easily pull you");
            Console.WriteLine(" in and make short work of you. A ROPE could be quite handy right now...");
            Console.WriteLine("What do you choose to do?\n");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Go to the QUARRY.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");

            //Add an if statement that checks for rope, if rope is in inventory you may cross the river
        }

        private void Quarry()
        {

        }

        private void Forest()
        {
            Console.Clear();
            Console.WriteLine("The FOREST is dark and crawling with danger. There is a small narrow ");
            Console.WriteLine("path leading into the arbour of death. As you enter, you hear something ");
            Console.WriteLine("scamper across the root riden ground ten feet in front of you, but you ");
            Console.WriteLine("cannot see what is was as it is dark as shit. You continue your trek ");
            Console.WriteLine("into the woods when you come across an opening. A small field of short ");
            Console.WriteLine("grass and blue sky over head from the lack of trees.");
            Console.WriteLine("What do you choose to do?\n");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
        }

        private void Basement()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private void Town()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private void Blacksmith()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private void Tavern()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private void Castle()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

    }
}

class Area
{
    //Forest
    //Mill
    //Field
    //River
    //Basement
    //Town
    //Blacksmith
    //Tavern
    //Quarry
    //Castle
}