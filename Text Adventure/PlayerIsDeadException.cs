using System;

namespace Text_Adventure;

public class PlayerIsDeadException : Exception
{
    public PlayerIsDeadException(string m)
    :base(m)
    { }
}