using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class Dictionary
    {
        public Dictionary<string, string> dictionary;

        public Dictionary()
        {
            dictionary = new Dictionary<string, string>();
        }
        public void Add(string key, string value)
        {
            dictionary.Add(key, value);
        }

        public void ShowAllWordsUE()
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine(" {0,10}     {1,10}", item.Key, item.Value);
            }

        }
        public void ShowAllWordsEU()
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine(" {0,10}     {1,10}", item.Value, item.Key);
            }

        }
        public bool TranslateUE(string word)
        {
            if (dictionary.ContainsKey(word) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Слово відсутнє");
                Console.ResetColor();
                return false;
            }
            else
            {
                Console.WriteLine("{0}  -  {1}", word, dictionary[word]);
                return true;
            }
        }
        public bool TranslateEU(string word)
        {
            if (dictionary.ContainsValue(word) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Слово відсутнє");
                Console.ResetColor();
                return false;
            }
            else
            {
                Console.WriteLine("{0}  -  {1}", dictionary[word], word);
                return true;
            }
        }

        //public string TranslateUE(string word)
        //{
        //    string result="";
        //    foreach (var item in dictionary.Keys)
        //    {
        //        if((string)dictionary[item]==word)
        //        {
        //            result=(string)item;
        //        }
        //    }
        //        return result;
        //}
        //public string TranslateEU(string word)
        //{
        //    string result = "";
        //    foreach (var item in dictionary.Keys)
        //    {
        //        if ((string)item == word)
        //        {
        //            result = (string)dictionary[item];
        //        }
        //    }
        //    return result;
        //}
    }
}
