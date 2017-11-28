using NUnit.Framework;
using System.Collections.Generic;

namespace APITest
{

    [TestFixture]
    public class ProductTests
    {
        ArrayOfProduct products;

        [SetUp]
        public void Setup()
        {
            products = Models.getProducts(new System.Uri("http://pltestautomationsample.azurewebsites.net/api/product"));
        }


        //Tests that products with given IDs have correct names and descriptions. 
        [TestCase("0", "Red Truck", "A red truck")]
        [TestCase("1", "Blue Car", "A blue car")]
        [TestCase("2", "Toaster", "It doesn't drive, but it toasts")]
        [TestCase("3", "Waffle iron", "It doesn't toast, but makes delicious waffles")]
        public void NameAndDescirptions(string id, string name, string desc)
        {
            Dictionary<string, string> item = Models.getItemByID(products, id);
            Assert.AreEqual(item["name"], name, "Name validation");
            Assert.AreEqual(item["desc"], desc, "Description validation");
        }
    }
}
