namespace SquadsMemory;

public class SquadMemory
{
    private List<IMemorize> Memorizes = new List<IMemorize>();
    private int MaxMemorySize = 5;

    public void AddMemorize(IMemorize memorize)
    {
        lock (Memorizes)
        {
            if (Memorizes.Count < MaxMemorySize)
            {
                Memorizes.Add(memorize);
                return;
            }

            var lowestPriorityMemorize = Memorizes.OrderBy(m => m.Priority).First();
            Memorizes.Remove(lowestPriorityMemorize);
            Memorizes.Add(memorize);
        }
    }
}