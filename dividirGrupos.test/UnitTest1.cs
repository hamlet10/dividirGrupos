/*

(-)
1. Si es null o empty => expection




*/


using NUnit.Framework;
using dividirGrupos;

namespace dividirGrupos.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That(() => GrupDiv.Input_Validator(""), Throws.Exception);
        }
    }
}