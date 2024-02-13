using NUnit.Framework;

namespace Tests.Edit
{
    public class EditModeTests
    {
        [Test]
        public void CheckSumPasses()
        {
            const int a = 2;
            const int b = 3;

            Assert.IsNotNull(a);
            Assert.IsNotNull(b);
            Assert.AreEqual((a + b), 8);
            Assert.AreNotEqual(a, b);
        }

        [Test]
        public void CheckStringPasses()
        {
            const string a = "Peepeepoopoo";

            Assert.IsNotNull(a);
            Assert.AreEqual("Peepeepoopoo", a);
        }
    }
}
