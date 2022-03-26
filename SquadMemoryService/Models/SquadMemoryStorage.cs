using System.Collections.Concurrent;

namespace SquadMemoryService.Models
{
    public class SquadMemoryStorage
    {
        public static SquadMemoryStorage GetInstance()
        {
            if (instance == null)
                instance = new SquadMemoryStorage();
            return instance;
        }
        private SquadMemoryStorage() { }

        private static SquadMemoryStorage instance;

        private ConcurrentDictionary<string, SquadMemory> squadMemoryStorage = new ConcurrentDictionary<string, SquadMemory>();

        public void AddMemorize(string squadId, Memorize memorize)
        {
            if (!squadMemoryStorage.ContainsKey(squadId))
            {
                squadMemoryStorage.TryAdd(squadId, new SquadMemory());
            }
            squadMemoryStorage[squadId].AddMemorize(memorize);
        }

        public Memorize GetMostImportantMemorize(string squadId)
        {
            if (!squadMemoryStorage.ContainsKey(squadId))
            {
                return null;
            }
            return squadMemoryStorage[squadId].GetMostImportantMemorize();
        }
    }
}
