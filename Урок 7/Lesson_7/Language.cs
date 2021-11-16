using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    public class Language
    {
        private string _name;
        private int _minLowCase;
        private int _maxLowCase;
        private int _minHighCase;
        private int _maxHighCase;
        private int _difference;

        public string Name { get { return _name; } }
        public int MinLowCase { get { return _minLowCase; } }
        public int MaxLowCase { get { return _maxLowCase; } }
        public int MinHighCase { get { return _minHighCase; } }
        public int MaxHighCase { get { return _maxHighCase; } }
        public int Difference { get { return _difference; } } 

        public Language(string name, int minLowCase, int maxLowCase, int minHighCase, int maxHighCase)
        {
            _name = name;
            _minLowCase = minLowCase;
            _maxLowCase = maxLowCase;
            _minHighCase = minHighCase;
            _maxHighCase = maxHighCase;
            _difference = maxLowCase - minLowCase;
        }
    }
}
