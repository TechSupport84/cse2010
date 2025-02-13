public abstract class ChecklistGoal :Goal
{
    private int  _amountCompleted;
    private int  _target;
    private int  _bonus;


    public ChecklistGoal(string  name , string  description ,  string points, int amountCompleted, int target , int bonus) 
    :base (name ,  description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
 
    }

    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}