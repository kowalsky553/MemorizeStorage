namespace SquadsMemory.Memorize;

public interface IMemorize : IHavePrioriry
{
    DateTime MemorizeDate { get; set; }
    Dictionary<string, string> MemorizeMeta { get; set; }
}