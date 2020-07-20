public class MtDataFactory {
    private static string skillData;
    private static string abilityData;
    private static string unitData;
    private static string enemyData;

    public static string SkillData { get => skillData; set => skillData = value; }
    public static string AbilityData { get => abilityData; set => abilityData = value; }
    public static string UnitData { get => unitData; set => unitData = value; }
    public static string EnemyData { get => enemyData; set => enemyData = value; }

    public static void Init() {
        SkillDB.Init(SkillData);
        
        AbilityDB.Init(AbilityData);

        UnitDB.Init(UnitData);

        EnemyDB.Init(EnemyData);
    }
}