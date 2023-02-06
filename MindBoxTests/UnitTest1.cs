using MindBoxLibrary;

namespace MindBoxTests
{
    public class Tests
    {
        private Class1 _myClass;

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1Circle()
        {
            _myClass = new Class1(10);
            Assert.AreEqual(314.15926535897933, _myClass.Calculate());
            //Assert.Pass();
        }
        [Test]
        public void Test2Circle()
        {
            _myClass = new Class1(15);
            Assert.AreEqual(706.85834705770344, _myClass.Calculate());
        }
        [Test]
        public void Test1Triangle()
        {
            _myClass = new Class1(5, 3, 3);
            Assert.AreEqual(4.1457809879442502, _myClass.Calculate());
        }
        [Test]
        public void Test2Triangle()
        {
            _myClass = new Class1(10, 8, 5);
            Assert.AreEqual(19.810035335657531, _myClass.Calculate());
        }
        [Test]
        public void Test3Triangle()
        {
            _myClass = new Class1(5, 3, 4);
            Assert.AreEqual(6,_myClass.Calculate());
        }
    }
}