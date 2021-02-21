using System;
using System.Xml;

namespace SpaceClassLibrary
{
    public class Planet
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public Items Inventory { get; set; }

        Player newPlayer = new Player();

        //xmlstuff going on here. Left in in case we want to use it later on.
        //public string explName { get; set; }
        //public double explVal { get; set; }
        //public string fuelName { get; set; }
        //public double fuelVal { get; set; }
        //public string foodName { get; set; }
        //public double foodVal { get; set; }
        //public string radMedName { get; set; }
        //public double radMedVal { get; set; }
        //public string orbsName { get; set; }
        //public double orbsVal { get; set; }

        public void newPlayerInventory()
        {
            Console.WriteLine($"Player Inventory:\n" +
                $"Spaceoes: {newPlayer.SpaceosAmount}\n" +
                $"Food: {newPlayer.FoodAmount}\n" +
                $"Tools: {newPlayer.ToolAmount}\n" +
                $"Explodium: {newPlayer.ExplodiumAmount}\n" +
                $"Fuel: {newPlayer.FuelAmount}\n");
        }
        public void ToolsBuySell()
        {
            int newInput = 0;
            string inputQty;
            Console.WriteLine("Choose a number: 1) Buy 2) Sell 3) Exit");
            string firstInput = Console.ReadLine();
            switch (firstInput)
            {
                case "1":
                    {
                        Console.WriteLine($"Please enter the amount of {Inventory.ToolName} you want to buy!");
                        bool condition = true;
                        while (condition)
                        {
                            inputQty = Console.ReadLine();
                            newInput = int.Parse(inputQty);

                            if (newInput * Inventory.ToolSalePrice < newPlayer.SpaceosAmount)
                            {
                                newPlayer.SpaceosAmount -= (newInput * Inventory.ToolSalePrice);
                                newPlayer.ToolAmount += newInput;
                                Inventory.ToolQuantity -= newInput;
                                Console.WriteLine($"You purchased {newInput} Tools");
                                Console.WriteLine($"You now have {newPlayer.SpaceosAmount} of spaceos AND {newPlayer.ToolAmount} Tools");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                                this.BuySell();
                            }
                            else if (newInput * Inventory.ToolSalePrice > newPlayer.SpaceosAmount)
                            {
                                Console.WriteLine("You dont have enough money!\n" +
                                    "Hit enter to return to the menu.");
                                Console.ReadLine();
                                this.ToolsBuySell();
                            }
                        }
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine($"Please enter the amount of {Inventory.ToolName} you want to sell!");
                        bool condition = true;
                        while (condition)
                        {
                            inputQty = Console.ReadLine();
                            newInput = int.Parse(inputQty);

                            if (newInput < newPlayer.ToolAmount)
                            {
                                newPlayer.SpaceosAmount += (newInput * Inventory.ToolBuyPrice);
                                newPlayer.ToolAmount -= newInput;
                                Inventory.ToolQuantity += newInput;
                                Console.WriteLine($"You Sold {newInput} Tools");
                                Console.WriteLine($"You now have {newPlayer.SpaceosAmount} of spaceos AND {newPlayer.ToolAmount} Tools");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                                this.BuySell();
                            }
                            else if (newInput > newPlayer.ToolAmount)
                            {
                                Console.WriteLine("You do not have enough in your inventory!\n" +
                                    "Press any key to reurn to the menu!");
                                Console.ReadLine();
                                this.ToolsBuySell();
                            }
                        }
                        break;
                    }
                case "3":
                    {
                        this.Welcome();
                        break;
                    }
            }

        }
        public void ExplodiumBuySell()
        {
            int newInput = 0;
            string inputQty;
            Console.WriteLine("Choose a number: 1) Buy 2) Sell 3) Exit");
            string firstInput = Console.ReadLine();
            switch (firstInput)
            {
                case "1":
                    {
                        Console.WriteLine($"Please enter the amount of {Inventory.ExplodiumName} you want to buy!");
                        bool condition = true;
                        while (condition)
                        {
                            inputQty = Console.ReadLine();
                            newInput = int.Parse(inputQty);

                            if (newInput * Inventory.ExplodiumSalePrice < newPlayer.SpaceosAmount)
                            {
                                newPlayer.SpaceosAmount -= (newInput * Inventory.ExplodiumSalePrice);
                                newPlayer.ExplodiumAmount += newInput;
                                Inventory.ExplodiumQuantity -= newInput;
                                Console.WriteLine($"You purchased {newInput} explodium");
                                Console.WriteLine($"You now have {newPlayer.SpaceosAmount} of spaceos AND {newPlayer.ExplodiumAmount}");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                                this.BuySell();
                            }
                            else if (newInput * Inventory.ExplodiumSalePrice > newPlayer.SpaceosAmount)
                            {
                                Console.WriteLine("You dont have enough money!\n" +
                                    "Hit enter to return to the menu.");
                                Console.ReadLine();
                                this.ExplodiumBuySell();
                            }
                        }
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine($"Please enter the amount of {Inventory.ExplodiumName} you want to sell!");
                        bool condition = true;
                        while (condition)
                        {
                            inputQty = Console.ReadLine();
                            newInput = int.Parse(inputQty);

                            if (newInput < newPlayer.ExplodiumAmount)
                            {
                                newPlayer.SpaceosAmount += (newInput * Inventory.ExplodiumBuyPrice);
                                newPlayer.ExplodiumAmount -= newInput;
                                Inventory.ExplodiumQuantity += newInput;
                                Console.WriteLine($"You Sold {newInput} explodium");
                                Console.WriteLine($"You now have {newPlayer.SpaceosAmount} of spaceos AND {newPlayer.ExplodiumAmount} ");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                                this.BuySell();
                            }
                            else if (newInput > newPlayer.ExplodiumAmount)
                            {
                                Console.WriteLine("You do not have enough in your inventory!\n" +
                                    "Press any key to reurn to the menu!");
                                Console.ReadLine();
                                this.ExplodiumBuySell();
                            }
                        }
                        break;
                    }
                case "3":
                    {
                        this.Welcome();
                        break;
                    }

            }
        }
        public void FuelBuySell()
        {
            int newInput = 0;
            string inputQty;
            Console.WriteLine("Choose a number: 1) Buy 2) Sell 3) Exit");
            string firstInput = Console.ReadLine();
            switch (firstInput)
            {
                case "1":
                    {
                        Console.WriteLine($"Please enter the amount of {Inventory.FuelName} you want to buy!");
                        bool condition = true;
                        while (condition)
                        {
                            inputQty = Console.ReadLine();
                            newInput = int.Parse(inputQty);

                            if (newInput * Inventory.FuelSalePrice < newPlayer.SpaceosAmount)
                            {
                                newPlayer.SpaceosAmount -= (newInput * Inventory.FuelSalePrice);
                                newPlayer.FuelAmount += newInput;
                                Inventory.FuelQuantity -= newInput;
                                Console.WriteLine($"You purchased {newInput} gallons of fuel");
                                Console.WriteLine($"You now have {newPlayer.SpaceosAmount} of spaceos AND {newPlayer.FuelAmount} gallons of fuel");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                                this.BuySell();
                            }
                            else if (newInput * Inventory.FuelSalePrice > newPlayer.SpaceosAmount)
                            {
                                Console.WriteLine("You dont have enough money!\n" +
                                    "Hit enter to return to the menu.");
                                Console.ReadLine();
                                this.FuelBuySell();
                            }
                        }
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine($"Please enter the amount of {Inventory.FuelName} you want to sell!");
                        bool condition = true;
                        while (condition)
                        {
                            inputQty = Console.ReadLine();
                            newInput = int.Parse(inputQty);

                            if (newInput < newPlayer.FuelAmount)
                            {
                                newPlayer.SpaceosAmount += (newInput * Inventory.FuelBuyPrice);
                                newPlayer.FuelAmount -= newInput;
                                Inventory.FuelQuantity += newInput;
                                Console.WriteLine($"You Sold {newInput} gallons of fuel");
                                Console.WriteLine($"You now have {newPlayer.SpaceosAmount} of spaceos AND {newPlayer.FuelAmount} gallons of fuel");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                                this.BuySell();
                            }
                            else if (newInput > newPlayer.FuelAmount)
                            {
                                Console.WriteLine("You do not have enough in your inventory!\n" +
                                    "Press any key to reurn to the menu!");
                                Console.ReadLine();
                                this.FuelBuySell();
                            }
                        }
                        break;
                    }
                case "3":
                    {
                        this.Welcome();
                        break;
                    }

            }
        }
        public void FoodBuySell()
        {
            int newInput = 0;
            string inputQty;
            Console.WriteLine("Choose a number: 1) Buy 2) Sell 3) Exit");
            string firstInput = Console.ReadLine();
            switch (firstInput)
            {
                case "1":
                    {
                        Console.WriteLine($"Please enter the amount of {Inventory.FoodName} you want to buy!");
                        bool condition = true;
                        while (condition)
                        {
                            inputQty = Console.ReadLine();
                            newInput = int.Parse(inputQty);

                            if (newInput * Inventory.FoodSalePrice < newPlayer.SpaceosAmount)
                            {
                                newPlayer.SpaceosAmount -= (newInput * Inventory.FoodSalePrice);
                                newPlayer.FoodAmount += newInput;
                                Inventory.FoodQuantity -= newInput;
                                Console.WriteLine($"You purchased {newInput} items of food");
                                Console.WriteLine($"You now have {newPlayer.SpaceosAmount} of spaceos AND {newPlayer.FoodAmount} items of food");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                                this.BuySell();
                            }
                            else if (newInput * Inventory.FoodSalePrice > newPlayer.SpaceosAmount)
                            {
                                Console.WriteLine("You dont have enough money!\n" +
                                    "Hit enter to return to the menu.");
                                Console.ReadLine();
                                this.FoodBuySell();
                            }
                        }
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine($"Please enter the amount of {Inventory.FoodName} you want to sell!");
                        bool condition = true;
                        while (condition)
                        {
                            inputQty = Console.ReadLine();
                            newInput = int.Parse(inputQty);

                            if (newInput < newPlayer.FoodAmount)
                            {
                                newPlayer.SpaceosAmount += (newInput * Inventory.FoodBuyPrice);
                                newPlayer.FoodAmount -= newInput;
                                Inventory.FoodQuantity += newInput;
                                Console.WriteLine($"You Sold {newInput} items of food");
                                Console.WriteLine($"You now have {newPlayer.SpaceosAmount} of spaceos AND {newPlayer.FoodAmount} items of food");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                                this.BuySell();
                            }
                            else if (newInput > newPlayer.FoodAmount)
                            {
                                Console.WriteLine("You do not have enough in your inventory!\n" +
                                    "Press any key to reurn to the menu!");
                                Console.ReadLine();
                                this.FoodBuySell();
                            }
                        }
                        break;
                    }
                case "3":
                    {
                        this.Welcome();
                        break;
                    }

            }

        }
        public void BuySell()
        {
            Console.Clear();
            bool condition = true;
            string select;
            newPlayerInventory();
            Console.WriteLine();
            Console.WriteLine($"Welcome to the {this.Name} Inventory!");
            Console.WriteLine($"Select the number of the item you wish to sell or purchase! \n" +
            $"1) {Inventory.FoodName}  Buy Price : {Inventory.FoodBuyPrice} Sell Price: {Inventory.FoodSalePrice} \n" +
            $"2) {Inventory.FuelName} Buy Price : {Inventory.FuelBuyPrice} Sell Price: {Inventory.FuelSalePrice} \n" +
            $"3) {Inventory.ExplodiumName} Buy Price : {Inventory.ExplodiumBuyPrice} Sell Price: {Inventory.ExplodiumSalePrice} \n" +
            $"4) {Inventory.ToolName}  Buy Price : {Inventory.ToolBuyPrice} Sell price: {Inventory.ToolSalePrice} \n" +
            $"5) Exit");

            select = Console.ReadLine();
            while (condition)
            {            
                
                if (select == "1")
                {
                    this.FoodBuySell();
                }
                else if (select == "2")
                {
                    this.FuelBuySell();
                }
                else if (select == "3")
                {
                    this.ExplodiumBuySell();
                }
                else if (select == "4")
                {
                    this.ToolsBuySell();
                }
                else if (select == "5")
                {
                    this.Welcome();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter a correct number!");
                    select = Console.ReadLine();
                    condition = true;
                }
            }
        }
        public void Explore()
        {
            Console.WriteLine(Description);
            Console.WriteLine($"Size: {Size}km");
            Console.WriteLine($"Planet vendor {Inventory}");
        }     
        public void Leave()
        {
            Console.WriteLine("Select L to confirm decision");
        }
        public void Welcome()
        {

            //if the input by the user parses to an integer and is between 1 and 5, return the input.
            
            int onplanet = 0;
            while (onplanet == 0)
            {           
                Console.WriteLine("Welcome to " + this.Name);
                Console.WriteLine("Would you like to:\n1) Explore\n2) Buy and Sell 3) Leave");
                string temp;
                int tempInt;
                int input = 0;
                temp = Console.ReadLine();
                if (int.TryParse(temp, out tempInt) && (tempInt >= 1 && tempInt <= 4))
                {
                    input = tempInt;
                }
                else
                {
                    //if the input by the user doesnt parse to an integer or is not between 1 and 5, do not return the input. Loop until user enters an acceptable value.
                    Console.WriteLine("Please enter a nubmer listed above and press enter.");
                    while (!int.TryParse(Console.ReadLine(), out tempInt) || (tempInt < 1 || tempInt > 4))
                    {
                        Console.WriteLine("Please enter a nubmer listed above and press enter.");
                    }
                    input = tempInt;
                }
                switch (input)
                {
                    case 1: //Explore
                        this.Explore();
                        Console.ReadKey();
                        break;
                    case 2: //Buy
                        this.BuySell();
                        Console.ReadKey();
                        break;
                    case 3: //Leave
                        Console.WriteLine($"You wave goodbye to the citizens of {this.Name} as your scooter takes off.\nPress enter to head back to space.");
                        Console.WriteLine($"You used 10 gallons a fuel during your travel!\n" +
                        $"You have {newPlayer.FuelAmount - 10} gallons left");
                        Console.ReadLine();
                        onplanet = 1;
                        break;
                }
            }
            
        }
      
    }
}
