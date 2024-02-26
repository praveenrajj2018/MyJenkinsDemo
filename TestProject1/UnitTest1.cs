
using Jenkins;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TextMe obj1 = new TextMe();
            String result = obj1.SayMyname(1);
            Assert.AreEqual("jenkinspass", result);
        }

        [Test]
        public void Test_SayMyname()
        {
            TextMe obj1 = new TextMe();
            String result=obj1.SayMyname(1);
            Assert.AreEqual("jenkinspass", result);



        }
    }
}