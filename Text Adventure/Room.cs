using System;

namespace Text_Adventure;

public abstract class Room
{
    protected string[] choicepro;
    protected string[] choiceContra;

    protected Random r = new Random();

    public string[] GetTexts()
    {
        return new string[] {choicepro[r.Next(choicepro.Length)], choiceContra[r.Next(choiceContra.Length)]};
    }
    public abstract string[] DoIt();
    public abstract string DoNot();
}