using FileHelpers;

namespace Mtdata
{
    [DelimitedRecord("|")]
    public class MtSkill
    {
        ///<summary>
        /// 스킬명
        /// </summary>
        public string Name {get; set;}
        ///<summary>
        /// 설명
        /// </summary>
        public string Desc {get; set;}
        ///<summary>
        /// 대상선택방법
        /// </summary>
        public RangeType RangeType {get; set;}
        ///<summary>
        /// ┣최소범위
        /// </summary>
        public int MinRange {get; set;}
        ///<summary>
        /// ┣최대범위
        /// </summary>
        public int MaxRange {get; set;}
        ///<summary>
        /// (범위
        ///  내 불필요)┣특수범위</summary>
        public int SpecialRange {get; set;}
        ///<summary>
        /// 소비할
        ///  것은?</summary>
        public CostType CostType {get; set;}
        ///<summary>
        /// ┗소비량
        /// </summary>
        public int Cost {get; set;}
        ///<summary>
        /// 기술의
        ///  종류</summary>
        public SkillType SkillType {get; set;}
        ///<summary>
        /// 위력에
        ///  영향주는 스테이터스1</summary>
        public StatType StatusType1 {get; set;}
        ///<summary>
        /// ┗영향도1
        /// [%]</summary>
        public int Affect1 {get; set;}
        ///<summary>
        /// 위력에
        ///  영향주는 스테이터스2</summary>
        public StatType StatusType2 {get; set;}
        ///<summary>
        /// ┗영향도2
        /// [%]</summary>
        public int Affect2 {get; set;}
        ///<summary>
        /// 발동자,대상 조절
        /// </summary>
        public TargetType TargetType {get; set;}
        ///<summary>
        /// 부여하는
        ///  상태1</summary>
        public int Buff1 {get; set;}
        ///<summary>
        /// ┗부여율1
        /// [%]</summary>
        public int Buff1Chance {get; set;}
        ///<summary>
        /// 부여하는
        ///  상태2</summary>
        public int Buff2 {get; set;}
        ///<summary>
        /// ┗부여율2
        /// [%]</summary>
        public int Buff2Chance {get; set;}
        ///<summary>
        /// 부여하는
        ///  상태3</summary>
        public int Buff3 {get; set;}
        ///<summary>
        /// ┗부여율3
        /// [%]</summary>
        public int Buff3Chance {get; set;}
        ///<summary>
        /// 회복하는
        ///  상태1</summary>
        public int BuffRevoke {get; set;}
        ///<summary>
        /// BP에
        ///  주는 대미지</summary>
        public int BPDamage {get; set;}
        ///<summary>
        /// 명중보정
        /// </summary>
        public int HitBonus {get; set;}
        ///<summary>
        /// 크리티컬보정
        /// </summary>
        public int CriticalBonus {get; set;}
        ///<summary>
        /// 효과가
        ///  자기에게 돌아옴?</summary>
        public int IsRecoil {get; set;}
        ///<summary>
        /// 사용에
        ///  필요한 Lv</summary>
        public int RequiredLv {get; set;}
        ///<summary>
        /// 사용에
        ///  필요한 Vo습득Lv</summary>
        public int RequiredVo {get; set;}
        ///<summary>
        /// 사용에
        ///  필요한 Da습득Lv</summary>
        public int RequiredDa {get; set;}
        ///<summary>
        /// 사용에
        ///  필요한 Vi습득Lv</summary>
        public int RequiredVi {get; set;}
        ///<summary>
        /// 아이템
        /// ?(1=YES)</summary>
        public BoolType IsItem {get; set;}
        ///<summary>
        /// 대사1
        /// </summary>
        public string Msg1 {get; set;}
        ///<summary>
        /// 대사2
        /// </summary>
        public string Msg2 {get; set;}
        ///<summary>
        /// 대사3
        /// </summary>
        public string Msg3 {get; set;}
        ///<summary>
        /// 기술
        ///  분류</summary>
        public SkillCategory SkillCategory {get; set;}
        ///<summary>
        /// 속성
        ///  분류</summary>
        public AttrCategory AttrCategory {get; set;}
        ///<summary>
        /// 거리분류
        /// </summary>
        public RangeCategory RangeCategory {get; set;}
        ///<summary>
        /// 간략연출:자기 중심
        /// </summary>
        public int SequenceIdSelf {get; set;}
        ///<summary>
        /// 간략연출:전체
        /// </summary>
        public int SequenceScreen {get; set;}
        ///<summary>
        /// 간략연출:개별 대상
        /// </summary>
        public int SequenceEachTarget {get; set;}
        ///<summary>
        /// 간략연출:중심 대상
        /// </summary>
        public int SequenceSkillTarget {get; set;}
        ///<summary>
        /// 간략연출:중심으로 궤적
        /// </summary>
        public int SequenceCenter {get; set;}
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
        BP = 0,
        Two = 1,
        Three = 10
    }
}