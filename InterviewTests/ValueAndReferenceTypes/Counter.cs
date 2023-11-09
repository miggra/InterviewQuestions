namespace InterviewTests.ValueAndReferenceType;

public interface ICounter
{
    int Count { get; set; }
}

public class Counter : ICounter
{
    public int Count { get; set; }
}