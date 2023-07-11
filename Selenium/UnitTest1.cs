
namespace Selenium
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        { 
            TestContext.Progress.WriteLine("This is Setup");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("This is test one");
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("This is test two");
            Assert.Pass();
        }

        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("This is Teardown");
        }
    }
}