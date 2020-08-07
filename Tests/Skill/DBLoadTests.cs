using System.Collections.Generic;
using System.IO;
using Mtdata;
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
            data = File.ReadAllText(data);
            Assert.NotZero(data.Length);

            SkillDB.Init(data);
            Assert.NotZero(SkillDB.Instance.Count);
            Assert.True(SkillDB.Instance.ContainsKey("레지스트"));
            Assert.AreEqual(RangeType.E, SkillDB.Instance["레지스트"].RangeType);
            Assert.AreEqual(4, (int)SkillDB.Instance["레지스트"].RangeType);
        }
        [Test]
        public void TestAbilityDB()
        {
            string data = TestContext.RootPath + "Resources/MtAbility.txt";
            data = File.ReadAllText(data);
            Assert.NotZero(data.Length);

            AbilityDB.Init(data);
            Assert.NotZero(AbilityDB.Instance.Count);
            Assert.True(AbilityDB.Instance.ContainsKey("순간이동"));
        }
        [Test]
        public void TestUnitDB()
        {
            string data = TestContext.RootPath + "Resources/MtUnit.txt";
            data = File.ReadAllText(data);
            Assert.NotZero(data.Length);

            UnitDB.Init(data);
            Assert.NotZero(UnitDB.Instance.Count);
            Assert.True(UnitDB.Instance.ContainsKey("[Character]akizuki_ritsukoA"));
            Assert.AreEqual(UnitType.Vi, UnitDB.Instance["[Character]akizuki_ritsukoA"].UnitType);
        }
        [Test]
        public void TestEnemyDB()
        {
            string data = TestContext.RootPath + "Resources/MtEnemy.txt";
            data = File.ReadAllText(data);
            Assert.NotZero(data.Length);

            EnemyDB.Init(data);
            Assert.NotZero(EnemyDB.Instance.Count);
            Assert.True(EnemyDB.Instance.ContainsKey("[Monster]Unknown01"));
        }
        
        [Test]
        public void TestDBFactory()
        {
            
            string data = TestContext.RootPath + "Resources/MtSkill.txt";
            data = File.ReadAllText(data);
            MtDataFactory.SkillData = data;
            
            data = TestContext.RootPath + "Resources/MtAbility.txt";
            data = File.ReadAllText(data);
            MtDataFactory.AbilityData = data;
            
            data = TestContext.RootPath + "Resources/MtUnit.txt";
            data = File.ReadAllText(data);
            MtDataFactory.UnitData = data;

            data = TestContext.RootPath + "Resources/MtEnemy.txt";
            data = File.ReadAllText(data);
            MtDataFactory.EnemyData = data;

            MtDataFactory.Init();
            
            Assert.NotZero(SkillDB.Instance.Count);
            Assert.NotZero(AbilityDB.Instance.Count);
            Assert.NotZero(UnitDB.Instance.Count);
            Assert.NotZero(EnemyDB.Instance.Count);
        }
    }
}