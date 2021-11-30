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

            Assert.That(latitude.Degrees, Is.EqualTo("0E"));
        }

        [Test]
        public void TestLongitudeConversions()
        {
            var latitude = new Longitude(2.07403);

            Assert.That(latitude.Degrees, Is.EqualTo("2.07403E"));
            Assert.That(latitude.DegreesMinutes, Is.EqualTo("2 04.4418'E"));
            Assert.That(latitude.DegreesMinutesSeconds, Is.EqualTo("2 04'26.508\"E"));
        }
    }
}
