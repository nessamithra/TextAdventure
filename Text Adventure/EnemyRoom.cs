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
        // int level = Form1.character.Level;
        // MaxHP = r.Next(Form1.character.Attack-1, Form1.character.Attack*level-1);
        MaxHP = r.Next(1, 10);
        HP = MaxHP;
        // attack = r.Next(level, level*2);
        attack = r.Next(1, 3);
    }
    
    /*
     * Fight the Enemy!
     */
    public override string[] DoIt()
    {
        Character chara = Form1.character;
        string[] story = new string[2];
        story[0] = "You attack the slime!";
        HP = (HP - chara.Attack < 0) ? 0 : (HP - chara.Attack);
        if (HP > 0)
        {
            chara.HP -= attack;
            if (chara.HP <= 0)
            {
                chara.HP = 0;
                throw new PlayerIsDeadException("Player is dead.");
            }
            story[1] = "Oh no! The slime hit you";
        }
        else
        {
            story[1] = "You killed the slime";
            chara.Xp += MaxHP/2;
        }
        
        return story;
    }

    /*
     * Run away and leave room
     */
    public override string DoNot()
    {
        return "You are running away";
    }
}