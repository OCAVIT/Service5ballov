public class Score
{
    public int Value { get; private set; }

    public void Increment() => Value++;
}