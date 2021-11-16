namespace Lesson_7
{
    public interface ICoder
    {
        string Encode(string str, Language lang);
        string Decode(string str, Language lang);
    }
}
