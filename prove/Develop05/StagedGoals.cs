using System;

public class StagedGoals : Goal
{
    private int _numOfStages;
    private int _numOfStagesDone;
    private int _bonus;

    //Constructors
    // For making a new one
    public StagedGoals (string name, string discription, int stageValue, int stageNum, int bonus) : base(name, discription, stageValue)
    {
        _numOfStages = stageNum;
        _numOfStagesDone = 0;
        _bonus = bonus;
    }
    // For making one from a save file
    public StagedGoals (string name, string discription, int stageValue, int stageNum, int bonus, int stageNumDone) : base(name, discription, stageValue)
    {
        _numOfStages = stageNum;
        _numOfStagesDone = stageNumDone;
        _bonus = bonus;
    }

    //Override Methods
    public override bool IsDone()
    {
        return _numOfStagesDone >= _numOfStages;
    }
    public override string GetSaveString()
    {
        return $"{base.GetSaveString()}|{_numOfStages}|{_bonus}|{_numOfStagesDone}";
    }
    public override int Event()
    {
        if (this.IsDone())
        {
            return 0;
        }
        else
        {
            _numOfStagesDone++;
            if (this.IsDone())
            {
                return _value + _bonus;
            }
            else
            {
                return _value;
            }
        }
    }
    public override string GetStringGoal()
    {
        return $"{base.GetStringGoal()} - {_numOfStages}/{_numOfStagesDone}";
    }
}