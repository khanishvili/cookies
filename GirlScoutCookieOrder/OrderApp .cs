using System;

namespace GirlScoutCookieOrder
{
    class OrderApp
    {
        static void Main(string[] args)
        {
            MasterOrder cart = new MasterOrder();
            
            bool runnmenu = true;
                                      // added varieties  in our Cart!!!!
            cart.AddOrder(new CookieOrder("chocolate", 2));
            cart.AddOrder(new CookieOrder("brownie", 22));
            cart.AddOrder(new CookieOrder("chocolate", 2));
            cart.AddOrder(new CookieOrder("mint", 41));
            cart.AddOrder(new CookieOrder("mint", 7));
            cart.AddOrder(new CookieOrder("cherry", 54));
            cart.AddOrder(new CookieOrder("cherry", 4));
            cart.AddOrder(new CookieOrder("fudge", 12));
            Console.WriteLine("Press 1 to Print list of cookies you ordering");
            Console.WriteLine("Press 2 to  print sum of all boxes in your cart");
            Console.WriteLine("Press 3 to remove by variety and push enter");
            Console.WriteLine("Press 4 to get amount of boxes by variety in your cart");
            do
            {
                string nameofvariety;
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        cart.ShowOrder(); //first
                        break;
                    case "2": // second  .  Total boxes in cart
                        Console.WriteLine("You are  ordering {0} boxes", cart.GetTotalBoxes());
                        break;
                    case "3":  //third. Remove Cockie from cart
                        Console.WriteLine("Enter variety wish to be removed from your cart  ");
                        nameofvariety = Console.ReadLine();
                        cart.RemoveVariety(nameofvariety.ToLower());
                        break;
                    case "4": // fourth  .  Total boxes of certain variety of boxes in cart
                        Console.WriteLine("Enter  name of variety to count amount of boxes in cart");
                        nameofvariety = Console.ReadLine();
                        
                        Console.WriteLine("Total amount of this variety is : {0} ", cart.GetVarietyBoxes(nameofvariety));
                        break;
                    case "0":
                        runnmenu = false;
                        break;
                }
            } while (runnmenu);
        }
      
    }
}
