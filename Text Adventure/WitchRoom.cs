using System;

namespace Text_Adventure;

public class WitchRoom : Room
{
    private string[] buyFail1Text;
    private string[] buyFail2Text;
    private string[] buyText;
    private string[] notEfficentText;
    private string[] efficentText;
    private string[] veryEfficentText;
    private string[] rejectText;
    public int Price { get; set; }
    public int Efficiency { get; set; }

    public WitchRoom(ref Character chara)
    {
        this.chara = chara;
        this.choiceProText = new[]
        {
            "Take the deal",
            "Gladly give her your gold"
        };
        this.choiceContraText = new[]
        {
            "Ignore her",
            "Refuse"
        };
        
        
        Price = r.Next(FormTextAdventure.character.Level, FormTextAdventure.character.Level * 2);
        Efficiency = r.Next(FormTextAdventure.character.Level, FormTextAdventure.character.MaxHp / 2 + 1);
        
        this.appearText = new[]
        {
            $"You find a Witch, who offers you a health potion for {Price} gold.",
            $"In the next room awaits you a witch with the offer of one health potion for {Price} gold.",
            $"You enter the room and see a witch with a potion and a note stating {Price} gold."
        };
        
        buyFail1Text = new[]
        {
            $"You could not buy the potion for {Price} gold.",
            "You do not have enough money.",
            $"You try to buy the potion but you only have {chara.Gold} gold.",
            "You offer the witch all you have but it is not enough."
        };
        buyFail2Text = new[]
        {
            "You leave the sad witch.",
            "You glare with dog eyes but the witch needs to feed her kids too.",
            "The witch gets angry and shoos you away.",
            "The witch looked really mad and you run away before she could curse you."
        };
        buyText = new[]
        {
            $"You bought the potion for {Price} gold.",
            "The witch thanks you and gives you the potion.",
            "'You invested your money well', the witch says and hands over the potion.",
            $"You hand over the the {Price} gold and the witch wishes you good luck."
        };
        veryEfficentText = new[]
        {
            $"The potion was very efficient.You regained { Efficiency } health.",
            $"You drink the potion and feel more lively then ever and regain { Efficiency } health.",
            $"What fabulous potion it regained {Efficiency} HP of your health!",
            $"Amazing! You seem to be lucky and regained {Efficiency} through the potion."
        };
        efficentText = new[]
        {
            $"The potion was efficient. You regain { Efficiency } health.",
            $"Well, it is a potion... You regain {Efficiency} HP.",
            $"Maybe this potion stayed too long in the shelf. You regain {Efficiency} HP.",
            $"Not that tasty but at least it healed {Efficiency} HP."
        };
        notEfficentText = new[]
        {
            $"The potion was not really efficient. You regained { Efficiency } health.",
            $"The god of luck seems to be busy you only regain {Efficiency} hp.",
            $"What junk did the witch sell you?! It could only regain {Efficiency} hp.",
            $"This potion was really not worth it... You regain {Efficiency} hp."
        };
        rejectText = new[]
        {
            "You leave the witch behind, she seemed disappointed...",
            "You go away and leave the witch lonely in the darkness of the dungeon.",
            "You look inside your leather bag with gold and enter the next room.",
            "Without even looking you go away. Wait...was that a curse? Well, whatever."
        };
    }
    
    /*
     * Try to buy potion
     */
    public override string[] DoIt()
    {
        string[] story = new string[2];
        
        if (chara.Gold - Price < 0)
        {
            story[0] = buyFail1Text[r.Next(buyFail1Text.Length)];
            story[1] = buyFail2Text[r.Next(buyFail2Text.Length)];
        }
        else
        {
            story[0] = buyText[r.Next(buyText.Length)];
            chara.Gold -= Price;
            chara.HP += Efficiency;
        
            if (Efficiency < (chara.MaxHp / 4))
            {
                story[1] = notEfficentText[r.Next(notEfficentText.Length)];
            }
            else if(Efficiency < (chara.MaxHp / 3))
            {
                story[1] = efficentText[r.Next(efficentText.Length)];
            }
            else
            {
                story[1] = veryEfficentText[r.Next(veryEfficentText.Length)];
            }
        }

        return story;
    }

    /*
     * Leave room
     */
    public override string DoNot()
    {
        return rejectText[r.Next(rejectText.Length)];
    }
}