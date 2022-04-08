namespace SquadsMemory.Memorize;

public class EmptyMemorize : IMemorize
{
    public int Priority
    {
        get { return 0; }
    }

    public DateTime MemorizeDate { get; set; }

    public Dictionary<string, string> MemorizeMeta
    {
        get =>
            new()
            {
                //Здесь можно захардкодить что-то на случай, если нечего рассказать
                {
                    "Message", "Да как-то ничего интересного и не было в последнее время."
                }
            };
        set {  }
    }
}