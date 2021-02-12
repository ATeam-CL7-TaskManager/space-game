using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetClasses
{
    public class Items
    {
       
        public virtual string FuelName { get; set; }
        public virtual int FuelQuantity { get; set; }
        public virtual int FuelBuyPrice { get; set; }
        public virtual int FuelSalePrice { get; set; }

        public virtual string ToolName { get; set; }
        public virtual int ToolQuantity { get; set; }
        public virtual int ToolBuyPrice { get; set; }
        public virtual int ToolSalePrice { get; set; }

        public virtual string FoodName { get; set; }
        public virtual int FoodQuantity { get; set; }
        public virtual int FoodBuyPrice { get; set; }
        public virtual int FoodSalePrice { get; set; }

        public virtual string ExplodiumName { get; set; }
        public virtual int ExplodiumQuantity { get; set; }
        public virtual int ExplodiumBuyPrice { get; set; }
        public virtual int ExplodiumSalePrice { get; set; }

        

    }

    class JTItems : Items
    {
        Player newPlayer = new Player();
        public override string FuelName { get; set; } = "Fuel";
            public override int FuelQuantity { get; set; } = 30;
            public override int FuelBuyPrice { get; set; } = 15;
            public override int FuelSalePrice { get; set; } = 20;

            public override string ToolName { get; set; } = "Tools";
            public override int ToolQuantity { get; set; } = 40;
            public override int ToolBuyPrice { get; set; } = 50;
            public override int ToolSalePrice { get; set; } = 70;

            public override string FoodName { get; set; } = "Food";
            public override int FoodQuantity { get; set; } = 55;
            public override int FoodBuyPrice { get; set; } = 5;
            public override int FoodSalePrice { get; set; } = 10;

            public override string ExplodiumName { get; set; } = "Explodium";
            public override int ExplodiumQuantity { get; set; } = 20;
            public override int ExplodiumBuyPrice { get; set; } = 120;
            public override int ExplodiumSalePrice { get; set; } = 150;

        public void displayInventory()
        {
            bool condition = false;

                Console.Title = "James Town Inventory";
                Console.WriteLine("Please select a number to access item information!");
                Console.WriteLine("");
            Console.WriteLine("1) Food 2) Fuel 3) Tools 4) Explodium");


            while (condition == false) 
            {
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine($"1) {FoodName}: QTY: {FoodQuantity} BUY PRICE: {FoodBuyPrice} SELL PRICE: {FoodSalePrice}");
                    Console.WriteLine();
                    Console.WriteLine("Select a number: 1) BUY 2) SELL 3) EXIT");
                    string secondInput = Console.ReadLine();
                    switch (secondInput)
                    {
                        case "1":
                            Console.WriteLine("Enter the quantity of Food you wish to buy");
                            int inputFoodQty = 0;
                            while (inputFoodQty == int.Parse(Console.ReadLine()))
                            {
                                    int totalPrice = (inputFoodQty * FoodSalePrice);
                                    newPlayer.SpaceosAmount -= totalPrice;
                                    newPlayer.FoodAmount += inputFoodQty;
                                    FoodQuantity -= inputFoodQty;
                                    Console.WriteLine($"You bought {inputFoodQty} units of Food.");
                                    Console.WriteLine($"You have {newPlayer.SpaceosAmount} of Spaceos left");
                            }                            
                            break;

                        case "2":
                            Console.WriteLine("Enter the quantity of Food you wish to sell");
                            int totalPrice = (inputFoodQty * FoodBuyPrice);
                            newPlayer.SpaceosAmount += totalPrice;
                            newPlayer.FoodAmount -= inputFoodQty;
                            FoodQuantity -= inputFoodQty;
                            Console.WriteLine($"You bought {inputFoodQty} units of Food.");
                            Console.WriteLine($"You have {newPlayer.SpaceosAmount} of Spaceos left");
                            break;
                          
                    }
                    break;
                }
                else if (userInput == "2")
                {
                    Console.WriteLine($"1) {FuelName}: QTY: {FuelQuantity} BUY PRICE: {FuelBuyPrice} SELL PRICE: {FuelSalePrice}");
                    break;
                }
                else if (userInput == "3")
                {
                    Console.WriteLine($"1) {ToolName}: QTY: {ToolQuantity} BUY PRICE: {ToolBuyPrice} SELL PRICE: {ToolSalePrice}");
                    break;
                }
                else if (userInput == "4")
                {
                    Console.WriteLine($"1) {ExplodiumName}: QTY: {ExplodiumQuantity} BUY PRICE: {ExplodiumBuyPrice} SELL PRICE: {ExplodiumSalePrice}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    
                }

                condition = true;
            }

                

            
        }
    }
    
    
}
