using FileHelpers;

namespace Mtdata
{
    [DelimitedRecord("|")]
    public class MtUnit
    {
        /// <summary>
        ///캐릭터 이름
        /// </summary>      
        public string Name { get; set; }
        /// <summary>
        ///칭호
        /// </summary>      
        public string Tag { get; set; }
        /// <summary>
        ///보행 그래픽 화상
        /// </summary>      
        public string CharaChip { get; set; }
        /// <summary>
        ///Lv
        /// </summary>      
        public int Lv { get; set; }
        /// <summary>
        ///HP
        /// </summary>      
        public int HP { get; set; }
        /// <summary>
        ///MaxHP
        /// </summary>      
        public int MaxHP { get; set; }
        /// <summary>
        ///BP
        /// </summary>      
        public int BP { get; set; }
        /// <summary>
        ///MaxBP
        /// </summary>      
        public int MaxBP { get; set; }
        /// <summary>
        ///공격
        /// </summary>      
        public int ATK { get; set; }
        /// <summary>
        ///방어
        /// </summary>      
        public int DEF { get; set; }
        /// <summary>
        ///마공
        /// </summary>      
        public int MAT { get; set; }
        /// <summary>
        ///마방
        /// </summary>      
        public int MDF { get; set; }
        /// <summary>
        ///명중
        /// </summary>      
        public int HIT { get; set; }
        /// <summary>
        ///민첩
        /// </summary>      
        public int SPD { get; set; }
        /// <summary>
        ///크리티컬[%]
        /// </summary>      
        public int Critical { get; set; }
        /// <summary>
        ///Vo
        /// </summary>      
        public int Vo { get; set; }
        /// <summary>
        ///Da
        /// </summary>      
        public int Da { get; set; }
        /// <summary>
        ///Vi
        /// </summary>      
        public int Vi { get; set; }
        /// <summary>
        ///[성장]최대HP 증가량/1Lv
        /// </summary>      
        public int Growth_MaxHP { get; set; }
        /// <summary>
        ///[성장]최대BP 증가량/1Lv
        /// </summary>      
        public int Growth_MaxBP { get; set; }
        /// <summary>
        ///[성장]공격 증가량/1Lv
        /// </summary>      
        public int Growth_ATK { get; set; }
        /// <summary>
        ///[성장]방어 증가량/1Lv
        /// </summary>      
        public int Growth_DEF { get; set; }
        /// <summary>
        ///[성장]마공 증가량/1Lv
        /// </summary>      
        public int Growth_MAT { get; set; }
        /// <summary>
        ///[성장]마방 증가량/1Lv
        /// </summary>      
        public int Growth_MDF { get; set; }
        /// <summary>
        ///[성장]명중 증가량/1Lv
        /// </summary>      
        public int Growth_HIT { get; set; }
        /// <summary>
        ///[성장]민첩 증가량/1Lv
        /// </summary>      
        public int Growth_SPD { get; set; }
        /// <summary>
        ///[성장]크리티컬 증가량/1Lv
        /// </summary>      
        public int Growth_Critical { get; set; }
        /// <summary>
        ///[성장]Vo 증가량/1Lv
        /// </summary>      
        public int Growth_Vo { get; set; }
        /// <summary>
        ///[성장]Da 증가량/1Lv
        /// </summary>      
        public int Growth_Da { get; set; }
        /// <summary>
        ///[성장]Vi 증가량/1Lv
        /// </summary>      
        public int Growth_Vi { get; set; }
        /// <summary>
        ///메인 장비
        /// </summary>      
        public int TagEquip { get; set; }
        /// <summary>
        ///장비1
        /// </summary>      
        public int Equip1 { get; set; }
        /// <summary>
        ///장비2
        /// </summary>      
        public int Equip2 { get; set; }
        /// <summary>
        ///장비3
        /// </summary>      
        public int Equip3 { get; set; }
        /// <summary>
        ///장비4
        /// </summary>      
        public int Equip4 { get; set; }
        /// <summary>
        ///장비5
        /// </summary>      
        public int Equip5 { get; set; }
        /// <summary>
        ///장비가능 타입1
        /// </summary>      
        public int _1 { get; set; }
        /// <summary>
        ///장비가능 타입2
        /// </summary>      
        public int _2 { get; set; }
        /// <summary>
        ///장비가능 타입3
        /// </summary>      
        public int _3 { get; set; }
        /// <summary>
        ///장비가능 타입4
        /// </summary>      
        public int _4 { get; set; }
        /// <summary>
        ///장비가능 타입5
        /// </summary>      
        public int _5 { get; set; }
        /// <summary>
        ///장비가능 타입6
        /// </summary>      
        public int _6 { get; set; }
        /// <summary>
        ///현재 Lv 취득 경험치
        /// </summary>      
        public int CurrentExp { get; set; }
        /// <summary>
        ///현재 Lv 필요 경험치
        /// </summary>      
        public int MaxExp { get; set; }
        /// <summary>
        ///필요 경험치 증가율[%]
        /// </summary>      
        public int Growth_MaxExp { get; set; }
        /// <summary>
        ///이동력
        /// </summary>      
        public int Move { get; set; }
        /// <summary>
        ///상단이동력
        /// </summary>      
        public int MoveUp { get; set; }
        /// <summary>
        ///하단이동력
        /// </summary>      
        public int MoveDown { get; set; }
        /// <summary>
        ///타입
        /// </summary>      
        public UnitType UnitType { get; set; }
    }
    public enum UnitType {
        None,
        Vo,
        Da,
        Vi,
        ToP
    }
}