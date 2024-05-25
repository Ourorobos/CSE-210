using System;

public class SimpleGoal : Goal
{
    //Member Variables
    public bool _done = false;

    //Constructor Method
    public SimpleGoal(string name, string discription, int value) : base(name, discription, value)
    {
        //Here we are
    }
    public SimpleGoal(string name, string discription, int value, bool state) : base(name, discription, value)
    {
        _done = state;
    }

    // Override Methods
    public override bool IsDone()
    {
        return _done;
    }
    public override string GetSaveString()
    {
        return $"{base.GetSaveString()}|{_done}";
    }
    public override int Event()
    {
        if (_done)
        {
            return 0;
        }
        else
        {
            _done = true;
            return _value;
        }
    }
}