namespace SquadMemoryService.Models
{
    public class Memorize
    {
        public int Importance { get; set; }

        public DateTime DateTime { get; set; }

        public Dictionary<string, string> MemorizeMeta = new Dictionary<string, string>();
    }
}
