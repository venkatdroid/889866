using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFoodSupply;
using NUnit.Framework;
namespace MyFoodSupplyTests
{
    [TestFixture]
    public class Tests
    {
        Program p;

        [OneTimeSetUp]
        public void SetUp()
        {
            p = new Program();
        }

        [Test]
        [TestCase("Idly", 30, "2023/01/02", 80.00)]
        public void FoodDetail_ObjectCreation_Test(string name, int dishType, string expiryDate, double price)
        {
            FoodDetail food = p.CreateFoodDetail(name, dishType,DateTime.Parse(expiryDate), price);
            Assert.AreEqual(typeof(FoodDetail), food.GetType());
        }


        [Test]
        [TestCase("abc", 30, "2023/01/02", 80.00)]
        public void FoodDetail_EmptyName_Exception(string name, int dishType, string expiryDate, double price)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price));
            Assert.That(ex.Message, Is.EqualTo("Dish name cannot be empty. Please provide valid value"));

        }


        [Test]
        [TestCase("Idly", 30, "2023/01/02", null)]
        public void FoodDetail_PriceLessThanZero_Exception(string name, int dishType, string expiryDate, double price)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price));
            Assert.That(ex.Message, Is.EqualTo("Incorrect value for dish price. Please provide valid value"));
        }



        [Test]
        [TestCase("Idly", 30, "2018/01/02", 80.00)]
        public void FoodDetail_DateLessThanCurrentDate_Exception(string name, int dishType, string expiryDate, double price)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price));
            Assert.That(ex.Message, Is.EqualTo("Incorrect expiry date. Please provide valid value"));
        }


        [Test]
        [TestCase(5, "2021/06/01", "Uber Eats", 140.00)]
        public void SupplyDetail_ObjectCreation_Test(int foodItemCount, String requestDate, string sellerName, double packingCharge)
        {
            FoodDetail fooditem = p.CreateFoodDetail("Biriyani", 10, DateTime.Parse("2022/12/02"), 100.00);
            SupplyDetail supplyDetail = p.CreateSupplyDetail(foodItemCount,DateTime.Parse(requestDate),sellerName,packingCharge,fooditem);
            Assert.AreEqual(typeof(SupplyDetail), supplyDetail.GetType());
        }



        [Test]
        [TestCase(null, "2020/10/01", "Uber Eats", 140.00)]
        public void SupplyDetail_CountLessThanZero_Exception(int foodItemCount, String requestDate, string sellerName, double packingCharge)
        {
            FoodDetail fooditem = p.CreateFoodDetail("Biriyani", 10, DateTime.Parse("2022/01/02"), 100.00);
            var ex = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, fooditem));
            Assert.That(ex.Message, Is.EqualTo("Incorrect food item count. Please check"));
        }




        [Test]
        [TestCase(5, "2020/10/01", "Uber Eats", 140.00)]
        public void SupplyDetail_DateLessThanCurrentDate_Exception(int foodItemCount, String requestDate, string sellerName, double packingCharge)
        {
            FoodDetail fooditem = p.CreateFoodDetail("Biriyani", 10, DateTime.Parse("2022/01/02"), 100.00);
            var ex = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, fooditem));
            Assert.That(ex.Message, Is.EqualTo("Incorrect food request date. Please provide valid value"));
        }



        [Test]
        [TestCase(5, "2020/10/01", "Uber Eats", 140.00)]
        public void SupplyDetail_FoodDetailObjectNull_Test(int foodItemCount, String requestDate, string sellerName, double packingCharge)
        {
            FoodDetail fooditem = null;
            SupplyDetail sd = p.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, fooditem);
            Assert.AreEqual(fooditem,sd);
        }


    }
}
