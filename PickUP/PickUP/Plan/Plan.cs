using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PickUP.Vocabulary;

namespace PickUP.Plan
{
    public class Plan
    {
        private string planName;
        private int length;
        private List<Word> data;

        public Plan(string planName)
        {
            this.planName = planName;
            this.length = 0;
            data = null;
        }

        public List<Word> getData()
        {
            return this.data;
        }

        public void addData(Word newWord)
        {
            if (!this.isContained(newWord))
            {
                data.Add(newWord);
                length++;
            }
            return;
        }

        public int getLength()
        {
            return this.length;
        }

        public bool isContained(Word newWord)
        {
            string spelling=newWord.getSpelling();
            if (length == 0)
                return false;
            for (int i = 0; i <= length; i++)
            {
                if (data[i].getSpelling().CompareTo(spelling) == 0)
                    return true;
            }
            return false;
        }
    }
}
