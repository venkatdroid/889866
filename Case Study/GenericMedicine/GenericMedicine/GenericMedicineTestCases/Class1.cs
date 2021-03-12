using GenericMedicine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace GenericMedicineTestCases
{
    [TestFixture]
    public class Class1
    {
        Program p;

        [OneTimeSetUp]
        public void SetUp()
        {
            p = new Program();
        }

        [Test]
        [TestCase("Tablet_1", null, "MedicTab", "2022 /01/02", 20.00)]
        public void Medicine_NameIsNullorNot(string name, string genericMedicineName, string composition, string expiryDate, double pricePerStrip) {

            var exp = Assert.Throws<Exception>(()=> p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip));
            Assert.That(exp.Message, Is.EqualTo("Generic Medicine name cannot be empty. Please provide valid value")); 
            
        }

        [Test]
        [TestCase("Tablet_1", "Paracetamol", "MedicTab", "2022 /01/02", 10)]
        public void Medicine_PriceLessThanZero(string name, string genericMedicineName, string composition, string expiryDate, double pricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect value for Medicine price per strip. Please provide valid value"));
        }

        [Test]
        [TestCase("Tablet_1", "Paracetamol", "MedicTab", "2020 /01/02", 10.00)]
        public void Medicine_DateLessThanCurrentDate(string name, string genericMedicineName, string composition, string expiryDate, double pricePerStrip)
        {
            var ex = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip));
            Assert.That(ex.Message, Is.EqualTo("Incorrect expiry date. Please provide valid value"));
        }

        [Test]
        [TestCase("Tablet_1", "Paracetamol", "MedicTab", "2022 /01/02", 10.00)]
        public void Medicine_ObjectCreation_Test(string name, string genericMedicineName, string composition, string expiryDate, double pricePerStrip)
        {
            Medicine medicine = p.CreateMedicineDetail(name, genericMedicineName, composition, DateTime.Parse(expiryDate), pricePerStrip); ;
            Assert.AreEqual(typeof(Medicine), medicine.GetType());
        }

        [Test]
        [TestCase(40, "2021/10/01", "Kochi")]
        public void Carton_ObjectCreation_Test(int medicineStripCount, string launchDate, string retailerAddress)
        {
            Medicine medicine_carton = p.CreateMedicineDetail("Tablet_1", "Paracetamol", "MedicTab", DateTime.Parse("2022 /01/02"), 10.00);
            CartonDetail carton = p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton);
            Assert.AreEqual(typeof(CartonDetail), carton.GetType());
        }

        [Test]
        [TestCase(-1 , "2021/10/01", "Kolkata")]
        public void Carton_StripCountLessThanZero(int medicineStripCount, string launchDate, string retailerAddress)
        {
            Medicine medicine_carton = p.CreateMedicineDetail("Tablet_1", "Paracetamol", "MedicTab", DateTime.Parse("2022 /01/02"), 10.00);
            var ex = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton));
            Assert.That(ex.Message, Is.EqualTo("Incorrect strip count. Please check"));
        }

        [Test]
        [TestCase(40, "2020/10/01", "Chennai")]
        public void Carton_DateLessThanCurrentDate(int medicineStripCount, string launchDate, string retailerAddress)
        {
            Medicine medicine_carton = p.CreateMedicineDetail("Dolo 650", " Micromol F Tablet", "Paracetamol", DateTime.Parse("2022/01/01"), 100.00);
            var ex = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton));
            Assert.That(ex.Message, Is.EqualTo("Incorrect launch date. Please provide valid value"));
        }

        [Test]
        [TestCase(40, "2022/10/01", "Banglore")]
        public void Carton_MedicineObjectNull_Test(int medicineStripCount, string launchDate, string retailerAddress)
        {
            Medicine medicine_carton = null;
            CartonDetail d = p.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine_carton);
            Assert.AreEqual(medicine_carton, d);
        }
    }
}
