using System;
using Xunit;
using System.Linq;
using GirlScoutCookieOrder;
namespace GirlScoutCookieOrder.test
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddOrder() //ADDES orders in list 
        {
            //ARRANGE
            MasterOrder testorder = new MasterOrder();
            //ACT
            testorder.AddOrder(new CookieOrder("fudge", 12));
             //ASSERT
            //Assert.Empty(testorder.orders); // Fails
            Assert.Equal("fudge", testorder.orders[0].Variety);
             
        }
        [Fact]
        public void ShouldGetTotalBoxes() // 
        {
            //ARRANGE
            MasterOrder testorder = new MasterOrder();
            //ACT
            testorder.AddOrder(new CookieOrder("fudge", 12));
            testorder.AddOrder(new CookieOrder("mix", 1));
            testorder.AddOrder(new CookieOrder("elephant", 2));
            int sum = testorder.GetTotalBoxes();
            //ASSERT           
            Assert.Equal(15,sum);

        }
        [Fact]
        public void ShouldRemoveVariety() //RemoveVariety using LINQQQQQ!!!
        {
            //ARRANGE
            MasterOrder testorder = new MasterOrder();
            //ACT
            testorder.AddOrder(new CookieOrder("fudge", 12));
            testorder.AddOrder(new CookieOrder("fudge", 12));
            testorder.AddOrder(new CookieOrder("mint", 12));
            testorder.RemoveVariety("Fudge");
            bool nottrue = testorder.orders.Exists(x => x.Variety == "Fudge");
            //ASSERT
            Assert.False(nottrue);
             
             

        }
        [Fact]
        public void ShouldGetVarietyBoxes()//GetVarietyBoxes 
        {
            //ARRANGE
            MasterOrder testorder = new MasterOrder();
            //ACT
            testorder.AddOrder(new CookieOrder("fudge", 12));
            testorder.AddOrder(new CookieOrder("zackscookies", 1));
            testorder.AddOrder(new CookieOrder("zackscookies", 2));
           int zacksboxes= testorder.GetVarietyBoxes("zackscookies");
            //ASSERT
            Assert.Equal(3, zacksboxes);
        }
    }
}
