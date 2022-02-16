namespace Text_Adventure;

public class ChestRoom : Room
{
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
        
        return true;
    }

    public override bool DoNot()
    {
        return true;
    }
}