using System;

namespace Text_Adventure;

public class Character
{
    private int Gold { get; set; }
    private int HP { get; set; }
    private int Attack { get; set; }
    
    public Character()
    {
        Gold = 0;
        HP = 20;
        Attack = 3;
    }
}