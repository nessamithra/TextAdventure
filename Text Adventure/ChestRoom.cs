namespace Text_Adventure;

public class ChestRoom : Room
{
    public bool Open { get; set; }

    public ChestRoom()
    {
        this.choicepro = new string[]
        {
            "Open chest",
            "Give in to your greed"
        };
        this.choiceContra = new string[]
        {
            "Leave chest",
            "Run away from chest"
        };
    }

    public override string[] DoIt()
    {
        string[] story = new string[2];
        story[0] = "You open the chest";
        switch (r.Next(4))
        {
            case 0:
            case 1:
                Form1.character.Gold += 1;
                story[1] = "You found one Gold";
                break;
            case 2:
                Form1.character.HP -= 1;
                // Todo: Add different storys 
                story[1] = "You lost one life";
                break;
            case 3:
                Form1.character.HP += 1;
                // Todo: Add different storys 
                story[1] = "You gain one life";
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