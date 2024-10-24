public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}