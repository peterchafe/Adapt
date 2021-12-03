using AdaptLib.Models;
using NUnit.Framework;

namespace AdaptLib.Tests.Models
{
    [TestFixture]
    internal sealed class LatitudeFixture
    {
        [Test]
        public void TestCreateDefaultLatitude()
        {
            var latitude = new Latitude();

            Assert.That(latitude.Degrees, Is.EqualTo("0°N"));
        }

        [Test]
        public void TestLatitudeConversions()
        {
            var latitude = new Latitude(41.403380);

            Assert.That(latitude.Degrees, Is.EqualTo("41.40338°N"));
            Assert.That(latitude.DegreesMinutes, Is.EqualTo("41°24.2028'N"));
            Assert.That(latitude.DegreesMinutesSeconds, Is.EqualTo("41°24'12.168\"N"));
        }

        [TestCase("41.40338", true, "41.40338°N")]
        [TestCase("-41.40338", true, "41.40338°S")]
        [TestCase("90.0001", false, "0°N")]
        [TestCase("-90.0001", false, "0°N")]
        public void TestParseDD(string input, bool expectedParseResult, string expectedLatitude)
        {
            Assert.That(Latitude.TryParse(input, out Latitude latitude), Is.EqualTo(expectedParseResult));
            Assert.That(latitude.Degrees, Is.EqualTo(expectedLatitude));
        }
    }
}
