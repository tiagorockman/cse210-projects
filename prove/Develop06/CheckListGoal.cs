public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailString(){
        throw new NotImplementedException();
    }
}