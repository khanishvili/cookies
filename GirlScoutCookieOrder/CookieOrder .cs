using System;
using System.Collections.Generic;
using System.Text;

namespace GirlScoutCookieOrder
{
   public  class CookieOrder
    {
       
        public string Variety { get; set; }
        public int NumBoxes { get; set; }
        public CookieOrder(string var, int countity)
        {
            Variety = var;
            NumBoxes = countity;
          
        }
        
    }
   
   
}
