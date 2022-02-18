﻿using System;

namespace Text_Adventure;

public class EnemyRoom : Room
{
    private string[] attackText;
    private string[] hitText;
    private string[] killText;
    private string[] escapeText;
    public int HP { get; set; }
    public int MaxHP { get; set; }
    private int attack;

    public EnemyRoom(ref Character chara)
    {
        this.chara = chara;
        this.choicepro = new[]
        {
            "Attack!",
            "Fight!",
            "Try to kill"
        };
        this.choiceContra = new[]
        {
            "Run Away",
            "Try to escape",
            "Spare his life"
        };
        
        int level = chara.Level;
        int upperBorder = Math.Max((chara.Attack * 2), (chara.Attack * level));
        MaxHP = r.Next(Form1.character.Attack-1, upperBorder);
        HP = MaxHP;
        attack = r.Next(level, level*2);
        
        attackText = new[]
        {
            $"You attack the slime and made {chara.Attack} damage.",
            $"You stab the slime and made {chara.Attack} damage.",
            $"You hit the slime and made {chara.Attack} damage."
        };
        hitText = new[]
        {
            $"Oh no! The slime hit you. You lost {attack} HP.",
            $"The slime deals {attack} damage to you.",
            $"You could not dodge and take {attack} damage.",
            $"The slime defends himself and deals {attack} damage."
        };
        killText = new[]
        {
            $"You kill the slime and got { MaxHP/2 } Xp and 1 gold.",
            $"You slaughter the slime and got { MaxHP/2 } Xp and 1 gold.",
            $"The slime slowly dies in your arms. You got { MaxHP/2 } Xp and 1 gold."
        };
        escapeText = new[]
        {
            "You run away.",
            "You escape from the slime.",
            "While you run away the slime observes you confused.",
            "You run away from the slime feeling his sad eyes on your back."
        };
    }
    
    /*
     * Fight the Enemy!
     */
    public override string[] DoIt()
    {
        string[] story = new string[2];
        story[0] = attackText[r.Next(attackText.Length)];
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
            story[1] = hitText[r.Next(hitText.Length)];
        }
        else
        {
            story[1] = killText[r.Next(killText.Length)];
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
        return escapeText[r.Next(escapeText.Length)];
    }
}