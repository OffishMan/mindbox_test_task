using TestJob;

namespace TestExamples
{
    public class TriangleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Init_ASideIsMinusOne_Should_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 1));
        }

        [Test]
        public void Init_BSideIsMinusOne_Should_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 1));
        }

        [Test]
        public void Init_CSideIsMinusOne_Should_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, -1));
        }

        [Test]
        public void Init_OneSideZero_Should_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 0));
        }

        [Test]
        public void Init_AllSidesCorrect_Should_DoesntThrow()
        {
            Assert.DoesNotThrow(() => new Triangle(1, 1, 1));
        }

        [Test]
        public void IsRectangular_True_Should_Pass()
        {
            var triangle = new Triangle(3, 4, 5);

            var isRectangular = triangle.IsRectangular();

            Assert.IsTrue(isRectangular);
        }

        [Test]
        public void IsRectangular_False_Should_Pass()
        {
            var triangle = new Triangle(3, 4, 6);

            var isRectangular = triangle.IsRectangular();

            Assert.IsFalse(isRectangular);
        }

        [Test]
        public void GetArea_Must6_Should_Pass()
        {
            var triangle = new Triangle(3, 4, 5);

            var area = triangle.GetArea();

            Assert.That(area, Is.EqualTo(6));
        }
    }
}