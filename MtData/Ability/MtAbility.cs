using FileHelpers;


namespace Mtdata
{
    [DelimitedRecord("|")]
    public class MtAbility
    {

        string name;
        string desc;
        string icon;
        int maxLv;
        int initCost;
        int addCost;
        int isUnique;
        int value1;
        int value2;
        int value3;

        
        /// <summary>
        /// 어빌리티명
        /// </summary>
        public string Name { get => name; set => name = value; }
        
        /// <summary>
        /// 설명
        /// </summary>
        public string Desc { get => desc; set => desc = value; }
        
        /// <summary>
        /// 아이콘
        /// </summary>
        public string Icon { get => icon; set => icon = value; }
        
        /// <summary>
        /// 최대Lv
        /// </summary>
        public int MaxLv { get => maxLv; set => maxLv = value; }
        
        /// <summary>
        /// 초기 코스트
        /// </summary>
        public int InitCost { get => initCost; set => initCost = value; }
        
        /// <summary>
        /// 증가 코스트
        /// </summary>
        public int AddCost { get => addCost; set => addCost = value; }
        
        /// <summary>
        /// 범용or고유(1=고유)
        /// </summary>
        public int IsUnique { get => isUnique; set => isUnique = value; }
        
        /// <summary>
        /// 값1
        /// </summary>
        public int Value1 { get => value1; set => value1 = value; }
        
        /// <summary>
        /// 값2
        /// </summary>
        public int Value2 { get => value2; set => value2 = value; }
        
        /// <summary>
        /// 값3
        /// </summary>
        public int Value3 { get => value3; set => value3 = value; }
    }
}