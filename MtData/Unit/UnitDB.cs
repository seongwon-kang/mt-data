using System.Collections.Generic;
using FileHelpers;

namespace Mtdata
{
    public class UnitDB
    {
        public static Dictionary<string, MtUnit> Instance = new Dictionary<string, MtUnit>();

        public static void Init(string path)
        {
            FileHelperEngine engine = new FileHelperEngine(typeof(MtUnit));

            List<object> units = engine.ReadStringAsList(path);
            int i = 0;

            foreach (var item in units)
            {
                var unit = item as MtUnit;
                if (!Instance.ContainsKey(unit.Name))
                {
                    Instance[unit.Name] = unit;
                }
                else
                {
                    Instance[unit.Name + (i++)] = unit;
                }
            }
        }
    }
}