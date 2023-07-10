namespace Interview.ReferenceandValueTypes;
public class Incrementer
{
    public class Counter
    {
        public int Count { get; set; }
    }

    public int IncrementAndReturn (int num)
    {
        num++;
        return num;
    }

    public void Increment (int num)
    {
        num++;
    }

    public void IncrementObj (object num)
    {
        num = (int)num + 1;
    }

    public void IncrementCounter (Counter counter)
    {
        this.Increment(counter.Count);
    }
}