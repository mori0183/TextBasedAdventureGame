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
            string action = toHere.ToUpper();
            switch (action)
            {
                case "LOOK AROUND":
                    LookAround();
                    break;

                case "TEST INVENTORY":
                    testInventory();
                    break;

                case "INVENTORY":
                    printInventory();
                    break;

                case "MILL":
                case "GO TO THE MILL":
                case "GO TO MILL":
                    Mill();
                    break;

                case "BASEMENT":
                case "GO TO BASEMENT":
                case "GO TO THE BASEMENT":
                    Basement();
                    break;

                case "BLACKSMITH":
                case "GO TO THE BLACKSMITH":
                case "GO TO BLACKSMITH":
                    Blacksmith();
                    break;

                case "FIELD":
                case "GO TO FIELD":
                case "GO TO THE FIELD":
                    FieldOfShit();
                    break;

                case "RIVER":
                case "GO TO THE RIVER":
                case "GO TO RIVER":
                    River();
                    break;

                case "FOREST":
                case "GO TO FOREST":
                case "GO TO THE FOREST":
                    Forest();
                    break;

                case "EXIT":
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
            Console.WriteLine("it is a hot summer day with a nice cool wind blowing east and everything is ");
            Console.WriteLine("perfect. All of a sudden a shriek comes from the north east of your position.");
            Console.WriteLine("Quickly you spin around and witness a massive DEMON carring a princess to the ");
            Console.WriteLine("castle behind the TOWN you just left.");
            Console.WriteLine("You feel you must do what you can to save the princess from her fate,\nbut you must aquire itams to aid you on your quest.");
            Console.WriteLine("You are facing a path that leads to a beautiful FIELD of tall grass.");
            Console.WriteLine("Behind you is the TOWN of Shmagma from which you have just exited.\n");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the TOWN.");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
            Console.WriteLine("");
        }

        private void FieldOfShit()
        {
            Console.Clear();
            Console.WriteLine("As you approach the field you notice a fairly recognizable smell");
            Console.WriteLine("You realize it is the smell of feces, but you are unable to ");
            Console.WriteLine("Identify the origins of what it came from.");
            Console.WriteLine("To the east lies the RIVER,\nto the south, the MILL,\nand to the west is the FOREST.\n");
            Console.WriteLine("What do you choose to do?");
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
            Console.WriteLine(" in and make short work of you. A ROPE could be quite handy right now...\n");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Go to the QUARRY.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");

            //Add an if statement that checks for rope, if rope is in inventory you may cross the river
        }

        private void Quarry()
        {
            //Greg is working on this part
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private void Mill()
        {
            Console.Clear();
            Console.WriteLine("A path from the field leads into a thin lining of trees. Behind the trees ");
            Console.WriteLine("you see an old MILL factory, it is very frail from wheather and time. you ");
            Console.WriteLine("walk to the old door that is barely hanging on to it's hinges, and slowly ");
            Console.WriteLine("push it open. The door opens half way then falls flat on the ground making ");
            Console.WriteLine("a loud BANG! Dust fills the air, but settles quickly. There is some old ");
            Console.WriteLine("equipment scattered about, and some remains of animals. There is an intact ");
            Console.WriteLine("door that leads to the BASEMENT to your left and a CHEST to your right.\n");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Go to the BASEMENT.");
            Console.WriteLine("Open the CHEST.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");

            //add a boolean that checks true for a rope when you opne the chest
            //The BASEMENT is just for funzies

            //Console.Beep();
            //foreach (string inventoryItem in inventory)
            //{
            //    if (inventoryItem == "Rope")
            //    {
            //        Console.WriteLine("You look around warily, fearing the rapids. You look around your bag for something to assist in crossing, and find a rope. It takes a coupld of tries, but you manage to hook the rope on a tough rock, and cross safely");
            //        beenHereWater = true;
            //        inventory.Remove("Rope");
            //        return;
            //    }

            //    else
            //    {
            //        continue;
            //    }
            //}

            //if (beenHereWater == true)
            //{
            //    Console.WriteLine("Having been here already, you cockily attempt to traverse the rapids. Your quick steps lead to your downfall");
            //    reset();
            //}

            //else
            //{
            //    Console.WriteLine("You gaze around in wonder. Having never seen such quick rapids before, so you take your time crossing. Unfortunately, taking your time means you were in the way when a tree came down, knocking you into the wtaer, where you freeze/drown/get clubbed by a tree to death.");
            //}
        }

        private void Forest()
        {
            Console.Clear();
            Console.WriteLine("The FOREST is dark and crawling with danger. There is a small narrow ");
            Console.WriteLine("path leading into the arbour of death. As you enter, you hear something ");
            Console.WriteLine("scamper across the root riden ground ten feet in front of you, but you ");
            Console.WriteLine("cannot see what is was as it is dark as shit. You continue your trek ");
            Console.WriteLine("into the woods when you come across an opening. A small field of short ");
            Console.WriteLine("grass and blue sky over head from the lack of trees.\n");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
        }

        private void Basement()
        {
            Console.Clear();
            Console.WriteLine("You open the door and head down the old rickety stairs to the BASEMENT.");
            Console.WriteLine("The further down you go the less you can see until nothing is visible.");
            Console.WriteLine("When you reach the last step you hear loud laboured breathing. The ");
            Console.WriteLine("breathing becomes louder and louder until it sounds like it is directly ");
            Console.WriteLine("in front of you. All of a sudden you hear a deafening hiss, then big red ");
            Console.WriteLine("eyes appear in font of you. Out of complete shock you wet your pants, shriek ");
            Console.WriteLine("and run back up the stairs and slam the door behind you. You can hear the ");
            Console.WriteLine("stairs cumble and fall apart behind the door. This calms you a little, but now ");
            Console.WriteLine("you have wet pants and reek of urine.\n");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Open the CHEST.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
        }

        private void Town()
        {
            Console.Clear();
            Console.WriteLine("You enter the town and the smell of baked goods and leather assult ");
            Console.WriteLine("your nostrils. The pleasant and familiar smell relaxes you and calms ");
            Console.WriteLine("you. The market is packed with people at every shop and commotion fills ");
            Console.WriteLine("air. To your left is the BLACKSMITH's, to your right is the TAVERN and ");
            Console.WriteLine("in front of you lies the gates to the CASTLE.");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the BLACKSMITH.");
            Console.WriteLine("Go to the TAVERN.");
            Console.WriteLine("Go to the CASTLE.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
        }

        private void Blacksmith()
        {
            Console.Clear();
            Console.WriteLine("You walk through the town and approach the BLACKSMITH's corner, the smell ");
            Console.WriteLine("of hot metal and smoke destroy the previous smell of baked goods from your ");
            Console.WriteLine("nostrils. You walk up to the BLACKSMITH and he glares at you with his one ");
            Console.WriteLine("eye, the other eye is covered with an eye patch from a recent accident.");
            Console.WriteLine("The BLACKSMITH grumbly asks you what you want.\n");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the TOWN.");
            Console.WriteLine("Tell the BLACKSMITH you don't like his face.");
            Console.WriteLine("Ask the BLACKSMITH if he can help you save the PRINCESS.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
        }

        private void Tavern()
        {
            //Greg has completed this section
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