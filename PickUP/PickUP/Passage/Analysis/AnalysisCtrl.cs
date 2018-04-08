using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace PickUP.Passage.Analysis
{
    class AnalysisCtrl
    {
        
        public static Hashtable getAllWords(string filePath)
        {
            Hashtable allWords = new Hashtable(10240);
                StreamReader newStreamReader = new StreamReader(filePath);
                char[] deli = { ' ', ',', '\t' };
                string[] words = null;
                while (newStreamReader.Peek() > 0)
                {
                    string line = newStreamReader.ReadLine();
                    words = line.Split(deli, StringSplitOptions.RemoveEmptyEntries);
                    if (words != null && words.Length > 0)
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            if (allWords.ContainsKey(words[i]))
                                allWords[words[i]] = (int)allWords[words[i]] + 1;
                            else
                                allWords.Add(words[i], 1);
                        }
                    }
                }
            return allWords;
        }
        
        public static void qucikSort(List<WordInfo> allWordInfos, int low, int high)
        {
            if (low >= high)
                return;
            int pLow = low;
            int pHigh = high;
            WordInfo value = allWordInfos[low];
            while (pLow < pHigh)
            {
                while ((WordInfo.Compare(allWordInfos[pHigh], value) <= 0) && pHigh > pLow)
                    pHigh--;
                if (WordInfo.Compare(allWordInfos[pHigh], value) > 0)
                {
                    allWordInfos[pLow] = allWordInfos[pHigh];
                    allWordInfos[pHigh] = value;
                    pLow++;
                }
                while ((WordInfo.Compare(allWordInfos[pLow], value) >= 0) && pHigh > pLow)
                    pLow++;
                if (WordInfo.Compare(allWordInfos[pLow], value) < 0)
                {
                    allWordInfos[pHigh] = allWordInfos[pLow];
                    allWordInfos[pLow] = value;
                    pHigh--;
                }
            }
            qucikSort(allWordInfos, low, pLow - 1);
            qucikSort(allWordInfos, pLow + 1, high);
        }
        

    }
}
