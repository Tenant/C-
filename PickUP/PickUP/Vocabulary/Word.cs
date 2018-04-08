using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PickUP.Vocabulary
{
    public class Word
    {
        private string spelling;
        private string meaning;

        public Word(string spelling, string meaning)
        {
            this.spelling = spelling;
            this.meaning = meaning;
        }

        public string getSpelling()
        {
            return spelling;
        }

        public string getMeaning()
        {
            return meaning;
        }
    }
}
