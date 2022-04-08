namespace SquadsMemory;

public interface IMemorize : IHavePrioriry
{
    DateTime MemorizeDate { get; set; }
}