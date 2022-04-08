namespace SquadsMemory;

public class FightingMemorize : IMemorize
{
    public int Priority
    {
        get
        {
            //Здесь можно сделать свои вычисления важности
            return 1;
        }
    }

    public DateTime MemorizeDate { get; set; }

    public Dictionary<string, string> MemorizeMeta { get; set; }
}