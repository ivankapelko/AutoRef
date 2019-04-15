using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRef
{
    public class RemoveStopWords
    {
        /// <summary>
        /// Список стоп слов русского языка.
        /// </summary>
        public HashSet<string> russianStopWords;

        /// <summary>
        /// Список стоп слов английского языка.
        /// </summary>
        public HashSet<string> englishStopWords;

        /// <summary>
        /// Удалятель стоп-слов. Решил пока что задавать пути к стоп словам в конструкторе, 
        /// так как неясно, как сделать конфиг, одинаково пригодный для .net и .net core. 
        /// </summary>
        /// <param name="russian"></param>
        /// <param name="english"></param>
        /// <param name="pathToRus"></param>
        /// <param name="pathToEng"></param>
        public RemoveStopWords(string pathToRus = "")
        {
            if (pathToRus == string.Empty)
                pathToRus = "RusStopWords.txt";
            russianStopWords = new HashSet<string>(File.ReadAllLines(pathToRus)
                .Where(l => !l.StartsWith("#"))
                .Select(l => l.Trim())
                .ToArray());
            

        }

      public List<string> Execute( List<string> tokens)
        {
            for (int i = 0; i < tokens.Count; i++)
                if (russianStopWords.Contains(tokens[i].Trim()))
                    tokens[i] = string.Empty;
            tokens.RemoveAll(x => x == String.Empty);
            return tokens;
        }

        public List<string> Execute(string[] tokens)
        {
            List<string> result = new List<string> { };
            for (int i = 0; i < tokens.Length; i++)
                if (!russianStopWords.Contains(tokens[i].Trim()))
                    result.Add(tokens[i]);
            return result;
        }
    }
}

