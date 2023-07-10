using Interview.ReferenceandValueTypes;

namespace InterviewTests;

public class QuestionsForValueAndReferenceTypeTests
{
    private readonly Incrementer incrementer;
    public QuestionsForValueAndReferenceTypeTests()
    {
        this.incrementer = new Incrementer();
    }

    [Fact]
    public void Test1()
    {
        // Arrange
        int x = 1;

        // Act
        incrementer.Increment(x);

        // Assert
        // TODO
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        int x = 1;

        // Act
        x = incrementer.IncrementAndReturn(x);

        // Assert
        // TODO
    }

    [Fact]
    public void Test3()
    {
        // Arrange
        int x = 1;
        Object obj = x;

        // Act
        incrementer.IncrementObj(obj);

        // Assert
        // TODO
    }

    [Fact]
    public void Test4()
    {
        // Arrange
        var counter = new Incrementer.Counter() { Count = 1 };

        // Act
        incrementer.IncrementCounter(counter);

        // Assert
        // TODO
    }
}