using System;
using System.Collections.Generic;
using System.Text;

namespace HackerHank
{
    class DictionariesMaps
    {
        public static void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> phoneBookDic = new Dictionary<string, string>();
            var query = string.Empty;
            string word = string.Empty;
            string value = string.Empty;

            for (int i = 0; i < n; i++)
            {
                word = Console.ReadLine();
                phoneBookDic.Add(word.Substring(0,word.IndexOf(" ")), word.Substring(word.IndexOf(" ")));
            }

            while (query == string.Empty)
            {
                query = Console.ReadLine();
                if (query != null)
                {
                    if (phoneBookDic.ContainsKey(query))
                    {
                        phoneBookDic.TryGetValue(query, out value);
                        Console.WriteLine(query + "=" + value.Trim());
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }
                    query = string.Empty;
                }
                
            }
        }
    }
}
