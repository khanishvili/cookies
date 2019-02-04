using System;

namespace GirlScoutCookieOrder
{
    class Program
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
                        Console.WriteLine("You are  ordering {0} boxes", cart.GetTotalBoxes());//
                        break;
                    case "3":  //third. Remove Cockie from cart
                        Console.WriteLine("Enter variety wish to be removed from your cart");
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
