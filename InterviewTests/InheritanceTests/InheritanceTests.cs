namespace InheritanceTasks;
public class A
{
    public virtual string Call()
    {
        return "A";
    }
}

public class B : A
{
    public override string Call()
    {
        string baseString = base.Call();
        return baseString + "B";
    }
}

public class C : B
{
    public override string Call()
    {
        string baseString = base.Call();
        return baseString + "C";
    }
}

public class QuestionsForInheritance
{
    [Fact]
    public void Test1()
    {
        // Arrange
        C c = new C();

        // Act
        var result =  c.Call();

        // Assert
        // TODO
    }
}