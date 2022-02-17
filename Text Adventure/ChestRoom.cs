namespace Text_Adventure;

public class ChestRoom : Room
{
    public bool Open { get; set; }

    public ChestRoom()
    {
        choicepro = new string[]
        {
            "Open chest",
            "Give in to your greed"
        };
        choiceContra = new string[]
        {
            "Leave chest",
            "Run away from chest"
        };
    }

    public override string[] DoIt()
    {
        Character chara = Form1.character;
        string[] story = new string[2];
        story[0] = "You open the chest";
        switch (r.Next(4))
        {
            case 0:
            case 1:
                // chara.Gold += chara.Level+2;
                // story[1] = $"You found {chara.Level+2} Gold";
                break;
            case 2:
                // chara.HP -= chara.Level;
                // Todo: Add different story lines
                // story[1] = $"You lost {chara.Level} life";
                break;
            case 3:
                // chara.HP += chara.Level;
                // Todo: Add different story lines 
                // story[1] = $"You gain {chara.Level} life";
                break;
            default:
                break;
        }
        Open = true;
        return story;
    }

    public override string DoNot()
    {
        return "You feel something bad about this chest and leave it";
    }
}