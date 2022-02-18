using System;

namespace Text_Adventure;

public abstract class Room
{
    protected string[] choiceProText;
    protected string[] choiceContraText;
    protected string[] appearText;
    protected Character chara;
    protected Random r = new Random();

    public string[] GetTexts()
    {
        return new string[] {choiceProText[r.Next(choiceProText.Length)], 
            choiceContraText[r.Next(choiceContraText.Length)],
            appearText[r.Next(appearText.Length)]
        };
    }
    public abstract string[] DoIt();
    public abstract string DoNot();
}