using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _points = 0;
    private int _level = 0;

    public GoalManager()
    {
        // Himmm...
    }

    // Display Method
    public void DisplayGoals()
    {
        if (1 > _goals.Count())
        {
            Console.WriteLine("You have no Goals");
        }
        else
        {
            int index = 0;
            foreach (Goal goal in _goals)
            {
                Console.Write($"{index}.");
                Console.WriteLine(goal.GetStringGoal());
                index++;
            }
        }
    }
    public void DisplayPlayerStats()
    {
        Console.WriteLine($"Player Level: {_level}");
        Console.WriteLine($"Total Xp: {_points}");
    }

    // Goal Action Methods
    public void AddGoal()
    {
        Console.WriteLine("""
        0.Simple Goal
        1.Continues
        2.Staged
        """);
        string type = this.UserInput("Enter Goal Type");
        string name = this.UserInput("Enter Goal Name");
        string discription = this.UserInput("Enter Goal Discription");
        int point = this.UserInputNum("Enter Goal Value");

        switch (type)
        {
            case "0":
                _goals.Add(new SimpleGoal(name, discription, point));
                break;
            
            case "1":
                _goals.Add(new ContinuesGoal(name, discription, point));
                break;
            
            case "2":
                int stages = this.UserInputNum("Enter Number of Goal Stages");
                int bonus = this.UserInputNum("Enter End Stage Bonus Value");
                 _goals.Add(new StagedGoals(name, discription, point, stages, bonus));
                 break;
            
            default:
                Console.WriteLine("Goal Type Error! Please try again.");
                break;
        }
    }
    public void GoalEvent()
    {
        int index = this.UserInputNum("Enter Goal Index");
        this.HandlePoints(_goals[index].Event());
    }
    
    // Load & Save Method
    public void SaveFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_level);
            writer.WriteLine(_points);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }
    }
    public void LoadFile(string filePath)
    {
        _goals = new List<Goal>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            _level = int.Parse(reader.ReadLine());
            _points = int.Parse(reader.ReadLine());
            
            string[] line;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine().Split("|"); //Add more to this
                
                switch (line.Count())
                {
                    case 3:
                        _goals.Add(new ContinuesGoal(line[0],line[1],int.Parse(line[2])));
                        break;

                    case 4:
                        _goals.Add(new SimpleGoal(line[0],line[1],int.Parse(line[2]),bool.Parse(line[3].ToLower())));
                        break;
                    
                    case 6:
                        _goals.Add(new StagedGoals(line[0],line[1],int.Parse(line[2]),int.Parse(line[3]),int.Parse(line[4]),int.Parse(line[5])));
                        break;
                    
                    default:
                        Console.WriteLine($"Read File Error {line.Count()} values");
                        break;
                }
            }
        }
    }

    // Private Methods
    private string UserInput(string prompt)
    {
        Console.Write($"{prompt}: ");
        return Console.ReadLine().ToLower().Trim();
    }
    private int UserInputNum(string prompt)
    {
        Console.Write($"{prompt}: ");
        return int.Parse(Console.ReadLine().ToLower().Trim());
    }
    private void HandlePoints(int points)
    {
        int tempPoints = _points + points;
        int levelXp = 100 * _level;
        if (tempPoints >= levelXp)
        {
            _points = tempPoints - levelXp;
            _level++;
        }
        else
        {
            _points = tempPoints;
        }
    }
}