using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class SpiceModelTests
    {
        [Test]
        public void PropertySpiceId_SetValue_StoresCorrectly()
        {
            SpiceModel spiceModel = new SpiceModel();
            spiceModel.SpiceId = 111;
            Assert.AreEqual(111, spiceModel.SpiceId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertySpiceName_SetValue_StoresCorrectly()
        {
            SpiceModel spiceModel = new SpiceModel();
            spiceModel.SpiceName = "A delicious spice";
            Assert.AreEqual("A delicious spice", spiceModel.SpiceName);
        }

        [Test]
        public void PropertyImagePath_SetValue_StoresCorrectly()
        {
            SpiceModel spiceModel = new SpiceModel();
            spiceModel.ImagePath = @"C:\good\path";
            Assert.AreEqual(@"C:\good\path", spiceModel.ImagePath);
        }
    }
}