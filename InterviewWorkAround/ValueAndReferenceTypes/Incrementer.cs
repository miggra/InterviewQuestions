namespace Interview.ReferenceandValueTypes;
public class Incrementer
{
    public int IncrementAndReturn (int num)
    {
        num++;
        return num;
    }

    public void Increment (int num)
    {
        num++;
    }

    public void IncrementObj (ref object num)
    {
        num = (int)num + 1;
    }

    public void IncrementCounter (Counter counter)
    {
        this.Increment(counter.Count);
    }

    public void IncrementCounter (ICounter counter)
    {
        this.Increment(counter.Count);
    }

    public void SetAnotherCounter (Counter counter)
    {
        Counter anoterCounter = new Counter(){Count = 2};
        counter = anoterCounter;
    }
}