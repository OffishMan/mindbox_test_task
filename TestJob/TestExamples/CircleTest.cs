using TestJob;

namespace TestExamples
{
    public class CircleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Init_SetRadiusMinus1_Should_ArgunentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }        
        
        [Test]
        public void Init_SetRadiusZero_Should_ArgunentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }    
        
        [Test]
        public void Init_SetRadiusOne_Should_DoesntThrow()
        {
            Assert.DoesNotThrow(() => new Circle(1));
        }   
        
        [Test]
        public void GetArea_SetRadiusOne_Should_Pass()
        {
            var circle = new Circle(1);

            var area = circle.GetArea();

            Assert.That(area, Is.EqualTo(Math.PI));
        }
    }
}