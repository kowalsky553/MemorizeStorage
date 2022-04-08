using SquadsMemory.Memorize;

namespace SquadsMemory;

public class StoryMaker
{
    public string CreateStory(IMemorize memorize)
    {
        //Тут можно сделать логику по сборке сообщения в диалоге
        return memorize.MemorizeMeta.First().Value;
    }
}