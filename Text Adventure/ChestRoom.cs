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
        switch(r.Next(3))
        {
            case 1:
                Form1.character.Gold += 1;
                return true;
            case 2:
                Form1.character.HP -= 1;
                return true;
            default:
                return true;
        }
    }
    
    

    public override bool DoNot()
    {
        return true;
    }
}