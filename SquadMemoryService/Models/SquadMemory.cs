namespace SquadMemoryService.Models
{
    public class SquadMemory
    {
        private static int MemoryLimit = 5;

        private HashSet<Memorize> Memorizes = new HashSet<Memorize>();

        private Memorize? CheapestMemorize
        {
            get
            {
                return Memorizes.OrderBy(m => m.Importance).FirstOrDefault();
            }
        }

        public void AddMemorize(Memorize memorize)
        {
            if (Memorizes.Count < MemoryLimit)
            {
                Memorizes.Add(memorize);
            }
            else
            {
                if (CheapestMemorize.Importance < memorize.Importance)
                {
                    Memorizes.Remove(CheapestMemorize);
                    Memorizes.Add(memorize);
                }
            }
        }

        public Memorize GetMostImportantMemorize() => Memorizes.OrderByDescending(m => m.Importance).FirstOrDefault();

    }
}
