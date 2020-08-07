using System.Collections.Generic;
using FileHelpers;

namespace Mtdata
{
    /// <summary>
    /// Init()을 호출한 뒤에 Instance["Name"]으로 사용한다.
    /// </summary>
    public class UnitDB
    {
        /// <summary>
        /// MtUnit 데이터를 가진 전역 클래스.
        /// Charachip 데이터를 키로 가진다. (예: akizuki_risukoA)
        /// </summary>
        public static Dictionary<string, MtUnit> Instance = new Dictionary<string, MtUnit>();

        /// <summary>
        /// 데이터 파일을 이용해 초기화한다.
        /// </summary>
        /// <param name="data">유닛 데이터</param>
        public static void Init(string data)
        {
            FileHelperEngine engine = new FileHelperEngine(typeof(MtUnit));

            List<object> units = engine.ReadStringAsList(data);
            int i = 0;

            foreach (var item in units)
            {
                var unit = item as MtUnit;
                string[] parts = unit.CharaChip.Split('/');

                string key = parts[parts.Length - 1].Split('.')[0];

                if (!Instance.ContainsKey(key))
                {
                    Instance[key] = unit;
                }
                else
                {
                    Instance[key + (i++)] = unit;
                }
            }
        }
    }
}