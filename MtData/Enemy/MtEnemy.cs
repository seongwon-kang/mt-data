using FileHelpers;

[DelimitedRecord("|")]
public class MtEnemy {

    /*캐릭터 이름*/
    public string Name {get; set;}
    /*칭호*/
    public string Tag {get; set;}
    /*보행 그래픽 화상*/
    public string CharaChip {get; set;}
    /*얼굴 그래픽 화상*/
    public string __1 {get; set;}
    /*전투 그래픽 폴더명*/
    public string __2 {get; set;}
    /*-----*/
    public string __4 {get; set;}
    /*HP*/
    public int HP {get; set;}
    /*MaxHP*/
    public int MaxHP {get; set;}
    /*BP*/
    public int BP {get; set;}
    /*MaxBP*/
    public int MaxBP {get; set;}
    /*공격*/
    public int ATK {get; set;}
    /*방어*/
    public int DEF {get; set;}
    /*마공*/
    public int MAT {get; set;}
    /*마방*/
    public int MDF {get; set;}
    /*명중*/
    public int HIT {get; set;}
    /*민첩*/
    public int SPD {get; set;}
    /*크리티컬[%]*/
    public int Critical {get; set;}
    /*Vo*/
    public int Vo {get; set;}
    /*Da*/
    public int Da {get; set;}
    /*Vi*/
    public int Vi {get; set;}
    /*[성장]최대HP 증가량/1Lv*/
    public int Growth_MaxHP {get; set;}
    /*[성장]최대BP 증가량/1Lv*/
    public int Growth_MaxBP {get; set;}
    /*[성장]공격 증가량/1Lv*/
    public int Growth_ATK {get; set;}
    /*[성장]방어 증가량/1Lv*/
    public int Growth_DEF {get; set;}
    /*[성장]마공 증가량/1Lv*/
    public int Growth_MAT {get; set;}
    /*[성장]마방 증가량/1Lv*/
    public int Growth_MDF {get; set;}
    /*[성장]명중 증가량/1Lv*/
    public int Growth_HIT {get; set;}
    /*[성장]민첩 증가량/1Lv*/
    public int Growth_SPD {get; set;}
    /*[성장]크리티컬 증가량/1Lv*/
    public int Growth_Critical {get; set;}
    /*[성장]Vo 증가량/1Lv*/
    public int Growth_Vo {get; set;}
    /*[성장]Da 증가량/1Lv*/
    public int Growth_Da {get; set;}
    /*[성장]Vi 증가량/1Lv*/
    public int Growth_Vi {get; set;}
    /*메인 장비*/
    public int TagEquip {get; set;}
    /*장비1*/
    public int Equip1 {get; set;}
    /*장비2*/
    public int Equip2 {get; set;}
    /*장비3*/
    public int Equip3 {get; set;}
    /*장비4*/
    public int Equip4 {get; set;}
    /*장비5*/
    public int Equip5 {get; set;}
    /*타입*/
    public int type {get; set;}
    /*----*/
    public string __5 {get; set;}
    /*[적전용]입수 아이템*/
    public int _1 {get; set;}
    /*┗아이템 입수율[%]*/
    public int _2 {get; set;}
    /*[적전용]입수 의상*/
    public int _3 {get; set;}
    /*┗의상 입수율[%]*/
    public int _4 {get; set;}
    /*[적전용]입수 액세서리*/
    public int _5 {get; set;}
    /*┗액세서리 입수율[%]*/
    public int _6 {get; set;}
    /*취득경험치*/
    public int EarnExp {get; set;}
    /*취득경험치증가량/1Lv*/
    public int Growth_EarnExp {get; set;}
    /*취득금액*/
    public int EarnGold {get; set;}
    /*취득금액증가량/1Lv*/
    public int Growth_EarnGold {get; set;}
    /*이동력*/
    public int Move {get; set;}
    /*상단이동력*/
    public int MoveUp {get; set;}
    /*하단이동력*/
    public int MoveDown {get; set;}
    /*전투연출가능?(1=가능)*/
    public int _6_5 {get; set;}
    /*대사연출가능?(1=가능)*/
    public int _7 {get; set;}
    /*처치안해도 됨?(1=됨)*/
    public int _8 {get; set;}
    /*방향고정?(1=고정)*/
    public int _9 {get; set;}
    /*취득반짝조각 수*/
    public int Shiny {get; set;}
    /*처음부터 트리거ON(1=YES)*/
    public int _11 {get; set;}
    /*반격한다(1=YES)*/
    public int _12 {get; set;}
}