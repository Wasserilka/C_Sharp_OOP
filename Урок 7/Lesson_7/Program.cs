using System;

namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Language_EN = new Language("en", 97, 122, 65, 90);
            var Language_RU = new Language("ru", 1072, 1103, 1040, 1071);
            var NewACoder = new ACoder();
            var NewBCoder = new BCoder();

            var NewString_EN = "abcdefghijklmnopqrstuvwxyz";
            var NewString_RU = "абвгдежзийклмнопрстуфхцчшщъыьэюя";

            Console.WriteLine("ACoder:");
            Console.WriteLine(NewACoder.Encode(NewString_EN, Language_EN));
            Console.WriteLine(NewACoder.Decode(NewString_EN, Language_EN));
            Console.WriteLine(NewACoder.Encode(NewString_RU, Language_RU));
            Console.WriteLine(NewACoder.Decode(NewString_RU, Language_RU));

            Console.WriteLine("BCoder:");
            var EncodedString_EN = NewBCoder.Encode(NewString_EN, Language_EN);
            Console.WriteLine(EncodedString_EN);
            Console.WriteLine(NewBCoder.Decode(EncodedString_EN, Language_EN));

            var EncodedString_RU = NewBCoder.Encode(NewString_RU, Language_RU);
            Console.WriteLine(EncodedString_RU);
            Console.WriteLine(NewBCoder.Decode(EncodedString_RU, Language_RU));
        }
    }
}
