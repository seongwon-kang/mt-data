using System.Collections.Generic;
using FileHelpers;


namespace Mtdata
{    
    /// <summary>
    /// Init()을 호출한 뒤에 Instance["Name"]으로 사용한다.
    /// </summary>
    public class EnemyDB
    {
        /// <summary>
        /// MtEnemy 데이터를 가진 전역 Dictionary.
        /// charachip 데이터를 키로 가진다. (예: [Monster]Slime1_green)
        /// </summary>
        public static Dictionary<string, MtEnemy> Instance = new Dictionary<string, MtEnemy>();
        /// <summary>
        /// 데이터 파일을 이용해 초기화한다.
        /// </summary>
        /// <param name="data">적 데이터</param>
        public static void Init(string path)
        {
            FileHelperEngine engine = new FileHelperEngine(typeof(MtEnemy));

            List<object> enemys = engine.ReadStringAsList(path);
            int i = 0;

            foreach (var item in enemys)
            {
                var enemy = item as MtEnemy;
                string[] parts = enemy.CharaChip.Split('/');

                string key = parts[parts.Length - 1].Split('.')[0];

                if (!Instance.ContainsKey(key))
                {
                    Instance[key] = enemy;
                }
                else
                {
                    Instance[key + (i++)] = enemy;
                }
            }
        }
    }
}