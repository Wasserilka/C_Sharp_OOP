using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    public class ACoder : ICoder
    {
        public string Decode(string str, Language lang)
        {
            var result = "";
            foreach (char chr in str)
            {
                result += chr == lang.MinLowCase || chr == lang.MinHighCase ? (char)(chr + lang.Difference) : (char)(chr - 1);
            }
            return result;
        }

        public string Encode(string str, Language lang)
        {
            var result = "";
            foreach (char chr in str)
            {
                result += chr == lang.MaxLowCase || chr == lang.MaxHighCase ? (char)(chr - lang.Difference) : (char)(chr + 1);
            }
            return result;
        }
    }
}
