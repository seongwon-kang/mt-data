using FileHelpers;

namespace Mtdata
{
    [DelimitedRecord("|")]
    public class MtUnit
    {
        /*캐릭터 이름*/
        public string Name { get; set; }
        /*칭호*/
        public string Tag { get; set; }
        /*보행 그래픽 화상*/
        public string CharaChip { get; set; }
        /*Lv*/
        public int Lv { get; set; }
        /*HP*/
        public int HP { get; set; }
        /*MaxHP*/
        public int MaxHP { get; set; }
        /*BP*/
        public int BP { get; set; }
        /*MaxBP*/
        public int MaxBP { get; set; }
        /*공격*/
        public int ATK { get; set; }
        /*방어*/
        public int DEF { get; set; }
        /*마공*/
        public int MAT { get; set; }
        /*마방*/
        public int MDF { get; set; }
        /*명중*/
        public int HIT { get; set; }
        /*민첩*/
        public int SPD { get; set; }
        /*크리티컬[%]*/
        public int Critical { get; set; }
        /*Vo*/
        public int Vo { get; set; }
        /*Da*/
        public int Da { get; set; }
        /*Vi*/
        public int Vi { get; set; }
        /*[성장]최대HP 증가량/1Lv*/
        public int Growth_MaxHP { get; set; }
        /*[성장]최대BP 증가량/1Lv*/
        public int Growth_MaxBP { get; set; }
        /*[성장]공격 증가량/1Lv*/
        public int Growth_ATK { get; set; }
        /*[성장]방어 증가량/1Lv*/
        public int Growth_DEF { get; set; }
        /*[성장]마공 증가량/1Lv*/
        public int Growth_MAT { get; set; }
        /*[성장]마방 증가량/1Lv*/
        public int Growth_MDF { get; set; }
        /*[성장]명중 증가량/1Lv*/
        public int Growth_HIT { get; set; }
        /*[성장]민첩 증가량/1Lv*/
        public int Growth_SPD { get; set; }
        /*[성장]크리티컬 증가량/1Lv*/
        public int Growth_Critical { get; set; }
        /*[성장]Vo 증가량/1Lv*/
        public int Growth_Vo { get; set; }
        /*[성장]Da 증가량/1Lv*/
        public int Growth_Da { get; set; }
        /*[성장]Vi 증가량/1Lv*/
        public int Growth_Vi { get; set; }
        /*메인 장비*/
        public int TagEquip { get; set; }
        /*장비1*/
        public int Equip1 { get; set; }
        /*장비2*/
        public int Equip2 { get; set; }
        /*장비3*/
        public int Equip3 { get; set; }
        /*장비4*/
        public int Equip4 { get; set; }
        /*장비5*/
        public int Equip5 { get; set; }
        /*장비가능 타입1*/
        public int _1 { get; set; }
        /*장비가능 타입2*/
        public int _2 { get; set; }
        /*장비가능 타입3*/
        public int _3 { get; set; }
        /*장비가능 타입4*/
        public int _4 { get; set; }
        /*장비가능 타입5*/
        public int _5 { get; set; }
        /*장비가능 타입6*/
        public int _6 { get; set; }
        /*현재 Lv 취득 경험치*/
        public int CurrentExp { get; set; }
        /*현재 Lv 필요 경험치*/
        public int MaxExp { get; set; }
        /*필요 경험치 증가율[%]*/
        public int Growth_MaxExp { get; set; }
        /*이동력*/
        public int Move { get; set; }
        /*상단이동력*/
        public int MoveUp { get; set; }
        /*하단이동력*/
        public int MoveDown { get; set; }
        /*타입*/
        public int Type { get; set; }
    }
}