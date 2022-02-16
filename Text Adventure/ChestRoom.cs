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

    public override bool DoIt()
    {
        switch (r.Next(3))
        {
            case 0:
            case 1:
                Form1.character.Gold += 1;
                break;
            case 2:
                Form1.character.HP -= 1;
                break;
            default:
                break;
        }
        Open = true;
        return true;
    }

    public override bool DoNot()
    {
        return true;
    }
}