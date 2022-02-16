namespace Text_Adventure;

public class EnemyRoom : Room
{
    public int HP { get; set; }
    public int MaxHP { get; set; }
    private int attack;

    public EnemyRoom()
    {
        this.choicepro = new[]
        {
            "Attack!",
            "Fight!",
            "Try to kill",
        };
        this.choiceContra = new[]
        {
            "Run Away",
            "Try to escape"
        };
        MaxHP = this.r.Next(20);
        HP = MaxHP;
        attack = this.r.Next(1, 5);
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