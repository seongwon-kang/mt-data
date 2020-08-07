using System;
using System.Collections.Generic;
using FileHelpers;

namespace Mtdata
{
    public class SkillDB
    {
        public static Dictionary<string, MtSkill> Instance = new Dictionary<string, MtSkill>();

        public static void Init(string path)
        {
            FileHelperEngine engine = new FileHelperEngine(typeof(MtSkill));

            List<object> skills = engine.ReadStringAsList(path);
            int i = 0;

            foreach (var item in skills)
            {
                var skill = item as MtSkill;
                if (!Instance.ContainsKey(skill.Name))
                {
                    Instance[skill.Name] = skill;
                }
                else
                {
                    Instance[skill.Name + (i++)] = skill;
                }
            }
        }
    }
}