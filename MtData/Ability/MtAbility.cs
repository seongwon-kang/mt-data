using FileHelpers;

[DelimitedRecord("|")]
public class MtAbility {

    /*어빌리티명*/
    string name;
    /*설명*/
    string desc;
    /*아이콘*/
    string icon;
    /*최대Lv*/
    int maxLv;
    /*초기 코스트*/
    int initCost;
    /*증가 코스트*/
    int addCost;
    /*범용or고유(1=고유)*/
    int isUnique;
    /*값1*/
    int value1;
    /*값2*/
    int value2;
    /*값3*/
    int value3;

    public string Name { get => name; set => name = value; }
    public string Desc { get => desc; set => desc = value; }
    public string Icon { get => icon; set => icon = value; }
    public int MaxLv { get => maxLv; set => maxLv = value; }
    public int InitCost { get => initCost; set => initCost = value; }
    public int AddCost { get => addCost; set => addCost = value; }
    public int IsUnique { get => isUnique; set => isUnique = value; }
    public int Value1 { get => value1; set => value1 = value; }
    public int Value2 { get => value2; set => value2 = value; }
    public int Value3 { get => value3; set => value3 = value; }
}