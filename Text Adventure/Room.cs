using System;

namespace Text_Adventure;

public abstract class Room
{
    public string buttonTextYes;
    public string buttonTextNo;

    protected Random r = new Random();

    public abstract void DoIt();
    public abstract void DoNot();
}