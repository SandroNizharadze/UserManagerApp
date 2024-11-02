namespace Practice.Models;

public abstract class BaseClass
{
    private static int _idCounter = 0;
    public int Id { get; set; }

    protected BaseClass()
    {
        _idCounter++;
        Id = _idCounter;
    }
}