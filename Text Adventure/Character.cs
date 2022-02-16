using System;

namespace Text_Adventure;

public class Character
{
    public int Gold { get; set; }
    public int HP { get; set; }
    public int MaxHp { get; set; }
    public int Attack { get; set; }

    public Character()
    {
        Gold = 0;
        MaxHp = 20;
        HP = MaxHp;
        Attack = 3;
    }
}