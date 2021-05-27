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
            spiceModel.spice_id = 111;
            Assert.AreEqual(111, spiceModel.spice_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertySpiceName_SetValue_StoresCorrectly()
        {
            SpiceModel spiceModel = new SpiceModel();
            spiceModel.spice_name = "A delicious spice";
            Assert.AreEqual("A delicious spice", spiceModel.spice_name);
        }

        [Test]
        public void PropertyImagePath_SetValue_StoresCorrectly()
        {
            SpiceModel spiceModel = new SpiceModel();
            spiceModel.image_path = @"C:\good\path";
            Assert.AreEqual(@"C:\good\path", spiceModel.image_path);
        }
    }
}