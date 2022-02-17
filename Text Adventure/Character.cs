using System;

namespace Text_Adventure;

public class Character
{
    public int Gold { get; set; }

    private int hp;
    public int HP
    {
        get { return this.hp;}
        set
        {
            if (value<MaxHp)
            {
                this.hp = value;
            }
            if (this.hp <= 0)
            {
                this.hp = 0;
                throw new PlayerIsDeadException("Player is dead.");
            }
        }
    }

    public int MaxHp { get; set; }
    public int Attack { get; set; }

    private int level;
    public int Level { get; set; }
    private int xp;

    public int Xp
    {
        get => xp;
        set
        {
            if (value < Level * 5)
            {
                xp = value;
                Console.WriteLine($"Level: {Level}, Xp: {Xp}/{Level * 5}");
            }
            else
            {
                Level += 1;
                xp = 0;
                MaxHp += 2;
                Attack += 1;
                Console.WriteLine($"Level: {Level}, Xp: {Xp}/{Level * 5}");
            }
        }
    }

    public Character()
    {
        Gold = 0;
        MaxHp = 20;
        HP = MaxHp;
        Attack = 3;
        Level = 1;
        Xp = 0;
    }
}