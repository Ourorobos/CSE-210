using System;

public class ContinuesGoal : Goal
{
    //Constructor method
    public ContinuesGoal(string name, string discription, int value) : base(name, discription, value)
    {
        //done done done
    }

    //Override Methods
    public override bool IsDone()
    {
        return false; //You are never done
    }
    public override int Event()
    {
        return _value;
    }
}