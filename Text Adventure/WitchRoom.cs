namespace Text_Adventure;

public class WitchRoom : Room
{
    public int Price { get; set; }
    public int Efficenzy { get; set; }
    
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
        Efficenzy = r.Next(Form1.character.Level, Form1.character.MaxHp / 3 + 1);
    }
    
    public override string[] DoIt()
    {
        
    }

    public override string DoNot()
    {
        
    }
}