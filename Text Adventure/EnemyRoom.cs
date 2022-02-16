namespace Text_Adventure;

public class EnemyRoom : Room
{
    private int hp;
    private int attack;
    public override string[] GetTexts()
    {
        throw new System.NotImplementedException();
    }

    public EnemyRoom()
    {
        this.choicepro = new[]
        {
            "Run Away",
            "Try to escape"
        };
        this.choiceContra = new[]
        {
            "Attack!",
            "Fight!",
            "Try to kill",
        };
        hp = this.r.Next(20);
        attack = this.r.Next(5);
    }
    
    /*
     * Fight the Enemy!
     */
    public override bool DoIt()
    {
        hp -= Form1.character.Attack;
        if (hp > 0)
        {
            Form1.character.HP -= attack;
        }
        return hp <= 0;
    }

    /*
     * Run away and leave room
     */
    public override bool DoNot()
    {
        return true;
    }
}