using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using ServiceStack;

namespace MtDataTests
{
    public class DBLoadTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSkillDB()
        {
            string data = TestContext.RootPath + "Resources/MtSkill.txt";

            Assert.NotZero(data.Length);

            SkillDB.Init(data);
            Assert.NotZero(SkillDB.Instance.Count);
        }
        [Test]
        public void TestAbilityDB()
        {
            string data = TestContext.RootPath + "Resources/MtAbility.txt";

            Assert.NotZero(data.Length);

            AbilityDB.Init(data);
            Assert.NotZero(AbilityDB.Instance.Count);
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