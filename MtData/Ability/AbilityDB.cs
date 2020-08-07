using System.Collections.Generic;
using FileHelpers;
namespace Mtdata {
    public class AbilityDB {
        public static Dictionary<string, MtAbility> Instance = new Dictionary<string, MtAbility>();
        
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