using System;

namespace Text_Adventure;

public class Character
{
    public int Gold { get; set; }
    public int HP { get; set; }
    public int MaxHp { get; set; }
    public int Attack { get; set; }

    // public int Level { get; set; }

    public int Xp { get; set; }
    // public int Xp
    // {
    //     get => Xp;
    //     set
    //     {
            // if (value < Level * 5)
            // {
            // Xp = value;
            // Console.WriteLine($"Level: {Level}, Xp: {Xp}/{Level * 5}");
            // }
            // else
            // {
            //     Level = Level + 1;
            //     Xp = 0;
            //     MaxHp += 2;
            //     Console.WriteLine($"Level: {Level}, Xp: {Xp}/{Level * 5}");
            // }
            
    //     }
    // }

    public Character()
    {
        Gold = 0;
        MaxHp = 20;
        HP = MaxHp;
        Attack = 3;
        // Level = 1;
        Xp = 0;
    }
}