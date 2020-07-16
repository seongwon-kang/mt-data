using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using ServiceStack;

namespace MtDataTests
{
    public class SkillDBTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string data = TestContext.RootPath + "Resources/MtSkill2.txt";

            Assert.NotZero(data.Length);

            SkillDB.Init(data);
            Assert.NotZero(SkillDB.Instance.Count);
        }

        [Test]
        public void Test2()
        {
            string dummy = "a,b,c,d,e\n5,\"6,7\",,9,";
            var result = dummy.FromCsv<List<Dummy>>();
            Assert.NotNull(result);


            Assert.AreEqual("5", result[0].a);
            Assert.AreEqual("6,7", result[0].b);
            Assert.AreEqual(null, result[0].c);
            Assert.AreEqual("9", result[0].d);
        }

    }
    public class Dummy
    {
        public string a { get; set; }
        public string b { get; set; }
        public string c { get; set; }
        public string d { get; set; }
        private int e;
        public int E { get => e; set => e = value; }
    }
}