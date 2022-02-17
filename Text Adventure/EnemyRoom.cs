using System;

namespace Text_Adventure;

public class EnemyRoom : Room
{
    public int HP { get; set; }
    public int MaxHP { get; set; }
    private int attack;

    public EnemyRoom()
    {
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
        int level = Form1.character.Level;
        int upperBorder = Math.Max((Form1.character.Attack * 2), (Form1.character.Attack * level));
        MaxHP = r.Next(Form1.character.Attack-1, upperBorder);
        HP = MaxHP;
        attack = r.Next(level, level*2);
    }
    
    /*
     * Fight the Enemy!
     */
    public override string[] DoIt()
    {
        Character chara = Form1.character;
        string[] story = new string[2];
        story[0] = "You attack the slime!";
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
            story[1] = "Oh no! The slime hit you";
        }
        else
        {
            story[1] = $"You killed the slime and got { MaxHP/2 } Xp";
            chara.Xp = chara.Xp + MaxHP/2;
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