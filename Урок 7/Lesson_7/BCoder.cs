using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    public class BCoder : ICoder
    {
        public string Decode(string str, Language lang)
        {
            var result = "";
            foreach (char chr in str)
            {
                if (chr >= lang.MinLowCase && chr <= lang.MaxLowCase)
                {
                    result += (char)(lang.MaxLowCase - chr + lang.MinLowCase);
                }
                else if (chr >= lang.MinHighCase && chr <= lang.MaxHighCase)
                {
                    result += (char)(lang.MaxHighCase - chr + lang.MinHighCase);
                }
                else
                {
                    throw new Exception();
                }
            }
            return result;
        }

        public string Encode(string str, Language lang)
        {
            var result = "";
            foreach (char chr in str)
            {
                if (chr >= lang.MinLowCase && chr <= lang.MaxLowCase)
                {
                    result += (char)(lang.MaxLowCase - chr + lang.MinLowCase);
                }
                else if (chr >= lang.MinHighCase && chr <= lang.MaxHighCase)
                {
                    result += (char)(lang.MaxHighCase - chr + lang.MinHighCase);
                }
                else
                {
                    throw new Exception();
                }
            }
            return result;
        }
    }
}
