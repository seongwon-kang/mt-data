using System.Collections.Generic;
using FileHelpers;
namespace Mtdata {
    /// <summary>
    /// Init()을 호출한 뒤에 Instance["Name"]으로 사용한다.
    /// </summary>
    public class AbilityDB {
        /// <summary>
        /// MtAbility 데이터를 가진 전역 Dictionary.
        /// Name 데이터를 키로 가진다. (예: Vo타입)
        /// </summary>
        public static Dictionary<string, MtAbility> Instance = new Dictionary<string, MtAbility>();
        /// <summary>
        /// 데이터 파일을 이용해 초기화한다.
        /// </summary>
        /// <param name="data">어빌리티 데이터</param>
        public static void Init(string path) {
            FileHelperEngine engine = new FileHelperEngine(typeof(MtAbility));
            List<object> abilitys = engine.ReadStringAsList(path);
            int i = 0;

            foreach(var item in abilitys) {
                var ability = item as MtAbility;
                if (!Instance.ContainsKey(ability.Name)) {
                    Instance[ability.Name] = ability;
                } else {
                    Instance[ability.Name + (i++)] = ability;
                }
            }
        }
    }
}