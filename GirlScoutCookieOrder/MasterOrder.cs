using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GirlScoutCookieOrder
{
    class MasterOrder
    {
        List<CookieOrder> orders = new List<CookieOrder>();
      
        public void AddOrder(CookieOrder theOrder)
        {
            orders.Add(theOrder);
        }
        public int GetTotalBoxes()
        {
            int numberofboxes=0;
            for(int i = 0; i < orders.Count; i++)
            {
                numberofboxes += orders[i].NumBoxes;
            }
            return numberofboxes;
        } //done. It is in menu
        public void RemoveVariety(string name) //works
        {
            orders.RemoveAll(x => x.Variety == name);

        }
        public int GetVarietyBoxes(string variety)
        {
            int returnvalue=0;
            for (int i = 0; i < orders.Count; i++)//1
            {
                if (orders[i].Variety.Equals(variety))
                {
                    returnvalue += orders[i].NumBoxes;
                }
            }

            return returnvalue;
        }
        public void ShowOrder() //done.It is in menu
        {
            //Variety: Tagalongs Boxes: 1
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine("Variety: {0}  Boxes: {1}",
                    orders[i].Variety, 
                    orders[i].NumBoxes);
            }
           
        }   
        
    }
}
