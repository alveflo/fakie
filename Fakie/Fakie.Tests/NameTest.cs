using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fakie;

namespace Fakie.Tests
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        public void TestSurnameNotEmpty()
        {
            var surName = Faker.Name.SurName;
            Assert.AreNotSame(surName, string.Empty);
        }

        [TestMethod]
        public void TestLastnameStringNotEmpty()
        {
            var lastName = Faker.Name.LastName;
            Assert.AreNotSame(lastName, string.Empty);
        }
    }
}