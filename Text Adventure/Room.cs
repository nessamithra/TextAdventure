using System;

namespace Text_Adventure;

public abstract class Room
{
    public string buttonTextYes;
    public string buttonTextNo;
    protected string[] choicepro;
    protected string[] choiceContra;

    protected Random r = new Random();

    public abstract bool DoIt();
    public abstract bool DoNot();
}