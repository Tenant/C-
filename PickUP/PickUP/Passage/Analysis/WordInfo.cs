using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PickUP.Passage.Analysis
{
    class WordInfo
    {
        public string spelling, meaning;

        public WordInfo()
        {
        }

        public WordInfo(string spelling, string meaning)
        {
            this.spelling = spelling;
            this.meaning = meaning;
        }

        public static int Compare(WordInfo wordInfo1, WordInfo wordInfo2)
        {
            if (wordInfo1.spelling.CompareTo(wordInfo2.spelling) > 0)
                return 1;
            else if (wordInfo1.spelling.CompareTo(wordInfo2.spelling) < 0)
                return -1;
            else
                return 0;
        }
    }
}
