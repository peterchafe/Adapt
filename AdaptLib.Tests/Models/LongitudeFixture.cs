using AdaptLib.Models;
using NUnit.Framework;

namespace AdaptLib.Tests.Models
{
    internal sealed class LongitudeFixture
    {
        [Test]
        public void TestCreateDefaultLatitude()
        {
            var latitude = new Longitude();

            Assert.That(latitude.Degrees, Is.EqualTo("0°E"));
        }

        [Test]
        public void TestLongitudeConversions()
        {
            var latitude = new Longitude(2.07403);

            Assert.That(latitude.Degrees, Is.EqualTo("2.07403°E"));
            Assert.That(latitude.DegreesMinutes, Is.EqualTo("2°04.4418'E"));
            Assert.That(latitude.DegreesMinutesSeconds, Is.EqualTo("2°04'26.508\"E"));
        }

        [TestCase("41.40338", true, "41.40338°E")]
        [TestCase("-41.40338", true, "41.40338°W")]
        [TestCase("180.0001", false, "0°E")]
        [TestCase("-180.0001", false, "0°E")]
        public void TestParseDD(string input, bool expectedParseResult, string expectedLongitude)
        {
            Assert.That(Longitude.TryParse(input, out Longitude longitude), Is.EqualTo(expectedParseResult));
            Assert.That(longitude.Degrees, Is.EqualTo(expectedLongitude));
        }
    }
}
