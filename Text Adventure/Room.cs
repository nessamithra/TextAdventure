using System;

namespace Text_Adventure;

public abstract class Room
{
    protected string[] choicepro;
    protected string[] choiceContra;

    protected Random r = new Random();

    public abstract string[] GetTexts();
    public abstract bool DoIt();
    public abstract bool DoNot();
}