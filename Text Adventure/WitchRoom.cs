using System;

namespace Text_Adventure;

public class WitchRoom : Room
{
    public int Price { get; set; }
    public int Efficiency { get; set; }
    
    public WitchRoom()
    {
        this.choicepro = new[]
        {
            "Take the deal",
            "Gladly give her your gold"
        };
        this.choiceContra = new[]
        {
            "Ignore her",
            "Refuse"
        };
        Price = r.Next(Form1.character.Level, Form1.character.Level);
        Efficiency = r.Next(Form1.character.Level, Form1.character.MaxHp / 3 + 1);
    }
    
    public override string[] DoIt()
    {
        Character chara = Form1.character;
        string[] story = new string[2];
        
        if (chara.Gold - Price < 0)
        {
            story[0] = $"You could not buy the potion for {Price} gold";
            story[1] = "You leave the sad witch";
        }
        else
        {
            story[0] = $"You bought the potion for {Price} gold";
            chara.Gold -= Price;
            chara.HP += Efficiency;
        
            if (Efficiency < chara.MaxHp / 6)
            {
                story[1] = $"The potion was not really efficient. You regained { Efficiency } health.";
            }
            else if(Efficiency < chara.MaxHp / 4)
            {
                story[1] = $"The potion was efficient.You regained { Efficiency } health";
            }
            else
            {
                story[1] = $"The potion was very efficient.You regained { Efficiency } health";
            }
        }

        return story;
    }

    public override string DoNot()
    {
        return "You leave the witch behind, she seemed disappointed...";
    }
}