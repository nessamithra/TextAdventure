using System;

namespace Text_Adventure;

public class EnemyRoom : Room
{
    public int HP { get; set; }
    public int MaxHP { get; set; }
    private int attack;

    public EnemyRoom(Character chara)
    {
        this.chara = chara;
        this.choicepro = new[]
        {
            "Attack!",
            "Fight!",
            "Try to kill",
        };
        this.choiceContra = new[]
        {
            "Run Away",
            "Try to escape"
        };
        int level = chara.Level;
        int upperBorder = Math.Max((chara.Attack * 2), (chara.Attack * level));
        MaxHP = r.Next(Form1.character.Attack-1, upperBorder);
        HP = MaxHP;
        attack = r.Next(level, level*2);
    }
    
    /*
     * Fight the Enemy!
     */
    public override string[] DoIt()
    {
        string[] story = new string[2];
        story[0] = $"You attack the slime and made {chara.Attack} damage";
        HP = (HP - chara.Attack < 0) ? 0 : (HP - chara.Attack);
        if (HP > 0)
        {
            try
            {
                chara.HP -= attack;
            }
            catch (PlayerIsDeadException e)
            {
                throw e;
            }
            story[1] = $"Oh no! The slime hit you. You've lost {attack} HP";
        }
        else
        {
            story[1] = $"You killed the slime and got { MaxHP/2 } Xp and 1 gold";
            chara.Xp = chara.Xp + MaxHP/2;
            chara.Gold++;
        }
        
        return story;
    }

    /*
     * Run away and leave room
     */
    public override string DoNot()
    {
        return "You are running away";
    }
}