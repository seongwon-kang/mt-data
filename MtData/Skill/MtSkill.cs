using FileHelpers;

namespace Mtdata
{
    [DelimitedRecord("|")]
    public class MtSkill
    {
        /*스킬명*/
        private string name;
        /*설명*/
        private string desc;
        /*대상선택방법*/
        private int rangeType;
        /*┣최소범위*/
        private int minRange;
        /*┣최대범위*/
        private int maxRange;
        /*(범위 내 불필요)┣특수범위*/
        private int specialRange;
        /*소비할 것은?*/
        private int costType;
        /*┗소비량*/
        private int cost;
        /*기술의 종류*/
        private int skillType;
        /*위력에 영향주는 스테이터스1*/
        private int statusType1;
        /*┗영향도1[%]*/
        private int affect1;
        /*위력에 영향주는 스테이터스2*/
        private int statusType2;
        /*┗영향도2[%]*/
        private int affect2;
        /*발동자,대상 조절*/
        private int targetType;
        /*부여하는 상태1*/
        private int buff1;
        /*┗부여율1[%]*/
        private int buff1Chance;
        /*부여하는 상태2*/
        private int buff2;
        /*┗부여율2[%]*/
        private int buff2Chance;
        /*부여하는 상태3*/
        private int buff3;
        /*┗부여율3[%]*/
        private int buff3Chance;
        /*회복하는 상태1*/
        private int buffRevoke;
        /*BP에 주는 대미지*/
        private int bPDamage;
        /*명중보정*/
        private int hitBonus;
        /*크리티컬보정*/
        private int criticalBonus;
        /*효과가 자기에게 돌아옴?*/
        private int isRecoil;
        /*사용에 필요한 Lv*/
        private int requiredLv;
        /*사용에 필요한 Vo습득Lv*/
        private int requiredVo;
        /*사용에 필요한 Da습득Lv*/
        private int requiredDa;
        /*사용에 필요한 Vi습득Lv*/
        private int requiredVi;
        /*아이템?(1=YES)*/
        private int isItem;
        /*대사1*/
        private string msg1;
        /*대사2*/
        private string msg2;
        /*대사3*/
        private string msg3;
        /*기술 분류*/
        private int skillCategory;
        /*속성 분류*/
        private int attrCategory;
        /*거리분류*/
        private int rangeCategory;
        /*간략연출:자기 중심*/
        private int sequenceIdSelf;
        /*간략연출:전체*/
        private int sequenceScreen;
        /*간략연출:개별 대상*/
        private int sequenceEachTarget;
        /*간략연출:중심 대상*/
        private int sequenceSkillTarget;
        /*간략연출:중심으로 궤적*/
        private int sequenceCenter;

        ///<summary>
        /// 스킬명
        /// </summary>
        public string Name { get => name; set => name = value; }
        ///<summary>
        /// 설명
        /// </summary>
        public string Desc { get => desc; set => desc = value; }
        ///<summary>
        /// 대상선택방법
        /// </summary>
        public int RangeType { get => rangeType; set => rangeType = value; }
        ///<summary>
        /// ┣최소범위
        /// </summary>
        public int MinRange { get => minRange; set => minRange = value; }
        ///<summary>
        /// ┣최대범위
        /// </summary>
        public int MaxRange { get => maxRange; set => maxRange = value; }
        ///<summary>
        /// (범위
        ///  내 불필요)┣특수범위</summary>
        public int SpecialRange { get => specialRange; set => specialRange = value; }
        ///<summary>
        /// 소비할
        ///  것은?</summary>
        public int CostType { get => costType; set => costType = value; }
        ///<summary>
        /// ┗소비량
        /// </summary>
        public int Cost { get => cost; set => cost = value; }
        ///<summary>
        /// 기술의
        ///  종류</summary>
        public int SkillType { get => skillType; set => skillType = value; }
        ///<summary>
        /// 위력에
        ///  영향주는 스테이터스1</summary>
        public int StatusType1 { get => statusType1; set => statusType1 = value; }
        ///<summary>
        /// ┗영향도1
        /// [%]</summary>
        public int Affect1 { get => affect1; set => affect1 = value; }
        ///<summary>
        /// 위력에
        ///  영향주는 스테이터스2</summary>
        public int StatusType2 { get => statusType2; set => statusType2 = value; }
        ///<summary>
        /// ┗영향도2
        /// [%]</summary>
        public int Affect2 { get => affect2; set => affect2 = value; }
        ///<summary>
        /// 발동자
        /// ,대상 조절</summary>
        public int TargetType { get => targetType; set => targetType = value; }
        ///<summary>
        /// 부여하는
        ///  상태1</summary>
        public int Buff1 { get => buff1; set => buff1 = value; }
        ///<summary>
        /// ┗부여율1
        /// [%]</summary>
        public int Buff1Chance { get => buff1Chance; set => buff1Chance = value; }
        ///<summary>
        /// 부여하는
        ///  상태2</summary>
        public int Buff2 { get => buff2; set => buff2 = value; }
        ///<summary>
        /// ┗부여율2
        /// [%]</summary>
        public int Buff2Chance { get => buff2Chance; set => buff2Chance = value; }
        ///<summary>
        /// 부여하는
        ///  상태3</summary>
        public int Buff3 { get => buff3; set => buff3 = value; }
        ///<summary>
        /// ┗부여율3
        /// [%]</summary>
        public int Buff3Chance { get => buff3Chance; set => buff3Chance = value; }
        ///<summary>
        /// 회복하는
        ///  상태1</summary>
        public int BuffRevoke { get => buffRevoke; set => buffRevoke = value; }
        ///<summary>
        /// BP에
        ///  주는 대미지</summary>
        public int BPDamage { get => bPDamage; set => bPDamage = value; }
        ///<summary>
        /// 명중보정
        /// </summary>
        public int HitBonus { get => hitBonus; set => hitBonus = value; }
        ///<summary>
        /// 크리티컬보정
        /// </summary>
        public int CriticalBonus { get => criticalBonus; set => criticalBonus = value; }
        ///<summary>
        /// 효과가
        ///  자기에게 돌아옴?</summary>
        public int IsRecoil { get => isRecoil; set => isRecoil = value; }
        ///<summary>
        /// 사용에
        ///  필요한 Lv</summary>
        public int RequiredLv { get => requiredLv; set => requiredLv = value; }
        ///<summary>
        /// 사용에
        ///  필요한 Vo습득Lv</summary>
        public int RequiredVo { get => requiredVo; set => requiredVo = value; }
        ///<summary>
        /// 사용에
        ///  필요한 Da습득Lv</summary>
        public int RequiredDa { get => requiredDa; set => requiredDa = value; }
        ///<summary>
        /// 사용에
        ///  필요한 Vi습득Lv</summary>
        public int RequiredVi { get => requiredVi; set => requiredVi = value; }
        ///<summary>
        /// 아이템
        /// ?(1=YES)</summary>
        public int IsItem { get => isItem; set => isItem = value; }
        ///<summary>
        /// 대사1
        /// </summary>
        public string Msg1 { get => msg1; set => msg1 = value; }
        ///<summary>
        /// 대사2
        /// </summary>
        public string Msg2 { get => msg2; set => msg2 = value; }
        ///<summary>
        /// 대사3
        /// </summary>
        public string Msg3 { get => msg3; set => msg3 = value; }
        ///<summary>
        /// 기술
        ///  분류</summary>
        public int SkillCategory { get => skillCategory; set => skillCategory = value; }
        ///<summary>
        /// 속성
        ///  분류</summary>
        public int AttrCategory { get => attrCategory; set => attrCategory = value; }
        ///<summary>
        /// 거리분류
        /// </summary>
        public int RangeCategory { get => rangeCategory; set => rangeCategory = value; }
        ///<summary>
        /// 간략연출
        /// :자기 중심</summary>
        public int SequenceIdSelf { get => sequenceIdSelf; set => sequenceIdSelf = value; }
        ///<summary>
        /// 간략연출
        /// :전체</summary>
        public int SequenceScreen { get => sequenceScreen; set => sequenceScreen = value; }
        ///<summary>
        /// 간략연출
        /// :개별 대상</summary>
        public int SequenceEachTarget { get => sequenceEachTarget; set => sequenceEachTarget = value; }
        ///<summary>
        /// 간략연출
        /// :중심 대상</summary>
        public int SequenceSkillTarget { get => sequenceSkillTarget; set => sequenceSkillTarget = value; }
        ///<summary>
        /// 간략연출
        /// :중심으로 궤적</summary>
        public int SequenceCenter { get => sequenceCenter; set => sequenceCenter = value; }
    }

    public enum BoolType
    {
        FALSE = 0, TRUE = 1
    }

    public enum StatType
    {
        A = -1, B = 0, C = 11, D, E, F, G
    }

    public enum RangeCategory
    {
        Zero,
        One,
        Two = 121,
    }

    public enum AttrCategory
    {
        A, B, C, D
    }

    public enum SkillCategory
    {
        A, B, C, D, E, F
    }

    public enum RecoilType
    {
        A = -50, B = -30, C = -20, D = -10, E = -1, F = 1, G = 10, H = 20
    }


    public enum TargetType
    {
        A = -1, B, C
    }

    public enum SkillType
    {
        Zero,
        One,
        Two,
        C,
        D,
        E,
        F = 15
    }

    public enum RangeType
    {
        A, B, C, D, E
    }

    public enum CostType
    {

        Zero = -1,
        One = 0,
        Two = 1,
        Three = 10
    }
}