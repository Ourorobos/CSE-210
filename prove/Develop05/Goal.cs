using System;

public abstract class Goal
{
    //Member Variables
    private string _name;
    private string _discription;
    protected int _value;

    //Constructor Method
    public Goal(string name, string discription, int value)
    {
        _name = name;
        _discription = discription;
        _value = value;
    }

    // Virtual Mehtods
    public virtual string GetSaveString()
    {
        return $"{_name}|{_discription}|{_value}";
    }
    public virtual string GetStringGoal()
    {
        char flag;
        if (this.IsDone())
        {
            flag = 'X';
        }
        else
        {
            flag = ' ';
        }
        return $"[{flag}] {_name}, {_discription}";
    }

    // Abstract Methods
    public abstract bool IsDone();

    public abstract int Event();
}