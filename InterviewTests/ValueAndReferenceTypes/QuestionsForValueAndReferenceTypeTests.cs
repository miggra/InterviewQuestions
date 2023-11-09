namespace InterviewTests.ValueAndReferenceType;

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
        incrementer.IncrementObj(ref obj);

        // Assert
        Assert.Equal(2, obj);
    }

    [Fact]
    public void Test4()
    {
        // Arrange
        var counter = new Counter() { Count = 1 };

        // Act
        incrementer.IncrementCounter(counter);

        // Assert
        Assert.Equal(2, counter.Count);
    }

    [Fact]
    public void Test5()
    {
        // Arrange
        var counter = new Counter() { Count = 1 };

        // Act
        incrementer.SetAnotherCounter(counter);

        // Assert
        Assert.Equal(1, counter.Count);
    }

    [Fact]
    public void Level2Test1()
    {

        // Arrange
        Counter foo = new Counter() {Count = 1};

        // Act
        incrementer.IncrementCounter(foo);
        Console.WriteLine(foo.Count);

        incrementer.IncrementCounter(foo);
        Console.WriteLine(foo.Count);

        // Assert
    }
}