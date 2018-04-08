using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using TJU.SoftCourse;
using System.Data.OleDb;

namespace PickUP.Vocabulary.Add_from_passages
{
    class AddFromPassageCtrl
    {
        public  Hashtable getAllWords(string filePath)
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

        public void intoDataBase(Hashtable newHashtable)
        {
            OleDbConnection conn = OleDbConn.getConn();
            string spelling, meaning;
            foreach (DictionaryEntry de in newHashtable)
            {
                spelling=de.Key.ToString();
                meaning=de.Value.ToString();
                String sql = "insert into tbl_Vocabulary('spelling','meaning') Values('" + spelling + "','" + meaning + "')";
                OleDbConn.execNonQuery(sql);
            }
            
        }
    }
}
