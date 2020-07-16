using System.Collections.Generic;
using FileHelpers;

public class EnemyDB {
    public static Dictionary<string, MtEnemy> Instance = new Dictionary<string, MtEnemy>();
    
    public static void Init(string path) {
        FileHelperEngine engine = new FileHelperEngine(typeof(MtEnemy));
        
        List<object> enemys = engine.ReadFileAsList(path);
        int i = 0;

        foreach(var item in enemys) {
            var enemy = item as MtEnemy;
            if (!Instance.ContainsKey(enemy.Name)) {
                Instance[enemy.Name] = enemy;
            } else {
                Instance[enemy.Name + (i++)] = enemy;
            }
        }
    }
}