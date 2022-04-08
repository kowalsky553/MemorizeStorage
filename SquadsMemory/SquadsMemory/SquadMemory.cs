using SquadsMemory.Memorize;

namespace SquadsMemory;

public class SquadMemory
{
    private List<IHavePrioriry> Memorizes = new List<IHavePrioriry>();
    private int MaxMemorySize = 5;


    public void AddMemorize(IHavePrioriry memorize)
    {
        lock (Memorizes)
        {
            if (Memorizes.Count < MaxMemorySize)
            {
                Memorizes.Add(memorize);
            }
            else
            {
                var lowestPriorityMemorize = Memorizes.OrderBy(m => m.Priority).First();
                Memorizes.Remove(lowestPriorityMemorize);
                Memorizes.Add(memorize);
            }

            Memorizes = Memorizes.OrderBy(m => m.Priority).ToList();
        }
    }

    public IMemorize GetMemorize()
    {
        if (Memorizes.Count == 0)
            return new EmptyMemorize();
        var random = new Random();
        var index = random.Next(Memorizes.Count);
        return (IMemorize) Memorizes[index];
    }

    public void SetMaxMemorySize(int newMemorySize) => MaxMemorySize = newMemorySize;
}