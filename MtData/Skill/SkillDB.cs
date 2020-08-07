using System;
using System.Collections.Generic;
using FileHelpers;

namespace Mtdata
{
    /// <summary>
    /// Init()을 호출한 뒤에 Instance["Name"]으로 사용한다.
    /// </summary>
    public class SkillDB
    {   
        /// <summary>
        /// MtSkill 데이터를 가진 전역 Dictionary.
        /// 이름 데이터를 키로 가진다. (예: 싸우기)
        /// </summary>
        public static Dictionary<string, MtSkill> Instance = new Dictionary<string, MtSkill>();
        /// <summary>
        /// 데이터 파일을 이용해 초기화한다.
        /// </summary>
        /// <param name="data">스킬 데이터</param>
        public static void Init(string path)
        {
            FileHelperEngine engine = new FileHelperEngine(typeof(MtSkill));

            List<object> skills = engine.ReadStringAsList(path);
            int i = 0;

            foreach (var item in skills)
            {
                var skill = item as MtSkill;
                string[] parts = skill.Name.Split(']');

                string key = parts[parts.Length - 1];

                if (!Instance.ContainsKey(skill.Name))
                {
                    Instance[key] = skill;
                }
                else
                {
                    Instance[key + (i++)] = skill;
                }
            }
        }
    }
}