using System;

namespace Text_Adventure;

public class ChestRoom : Room
{
    public bool Open { get; set; }

    private string[] openChestMessage = new[]
    {
        "You open the chest",
        "Gave in to your greed",
        "You slowly come closer and lift the lid...",
        "Curious you look inside the chest"
    };

    private string[] findGoldMessage;
    private string[] loseLifeMessage;
    private string[] gainLifeMessage;
    private string[] doNotMessage;

    public ChestRoom(Character chara)
    {
        this.chara = chara;
        choicepro = new string[]
        {
            "Open chest",
            "Give in to your greed",
            "Risk a look"
        };
        choiceContra = new string[]
        {
            "Leave chest",
            "Run away from chest",
            "Do not risk a thing and go to the next room"
        };
        findGoldMessage = new[]
        {
            $"You found {chara.Level + 2} Gold.",
            $"In the Chest you found {chara.Level + 2} Gold.",
            $"You got {chara.Level + 2} Gold.",
            $"Pretty big chest for just {chara.Level + 2} Gold..."
        };
        loseLifeMessage = new[]
        {
            $"You lost {chara.Level} HP.",
            $"The chest explodes and you lost {chara.Level} HP.",
            $"Oh no, the chest is poisoned. You lost {chara.Level} HP.",
            $"Oh no, the chest was trapped and you lost {chara.Level} HP."
        };
        gainLifeMessage = new[]
        {
            $"You gain {chara.Level} HP.",
            $"You found a supe which healed you {chara.Level} HP.",
            $"Luckily you found a potion that healed you {chara.Level} HP.",
            $"You freed a fairy that was trapped in the chest. Thankfully she healed you {chara.Level} HP."
        };
        doNotMessage = new[]
        {
            "You feel something bad about this chest and leave it.",
            "This chest can't be good. You walk around it and into the next room.",
            "Is that blood coming out of the corners? You better go on quickly.",
            "A bad premonition comes over you and you move into the next room."
        };
    }

    public override string[] DoIt()
    {
        string[] story = new string[2];
        story[0] = openChestMessage[r.Next(openChestMessage.Length)];
        switch (r.Next(4))
        {
            case 0:
            case 1:
                chara.Gold += chara.Level + 2;
                story[1] = findGoldMessage[r.Next(findGoldMessage.Length)];
                break;
            case 2:
                try
                {
                    chara.HP -= chara.Level;
                }
                catch (PlayerIsDeadException e)
                {
                    throw e;
                }

                story[1] = loseLifeMessage[r.Next(loseLifeMessage.Length)];
                break;
            case 3:
                chara.HP += chara.Level;
                // Todo: Add different story lines 
                story[1] = gainLifeMessage[r.Next(gainLifeMessage.Length)];
                break;
            default:
                break;
        }

        Open = true;
        return story;
    }

    public override string DoNot()
    {
        return doNotMessage[r.Next(doNotMessage.Length)];
    }
}