using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRef.Tokens
{
    public class ParagraphToken : Token
    {
        public ParagraphToken()
        {
            TokenGenerator.CalculateValueForParagraphs += CalculateValue;
        }
        public List<SentenceToken> ListOfSentence { get; set; } = new List<SentenceToken>();

        public int Number { get; set; }
      

        public string GetListOfSentence()
        {
            string result = String.Empty;
            for(int i=0;i< ListOfSentence.Count;i++ )
            {
                result += String.Format("{0}. {1}", i, ListOfSentence[i].TextValue) + Environment.NewLine;
            }
            return result;
        }
        /// <summary>
        /// Содержится ли лемма в парарафе повторно
        /// </summary>
        /// <param name="lemma"></param>
        /// <returns></returns>
        public bool IsLemmaContainsInParagraph(string lemma)
        {
            List<WordToken> words = new List<WordToken> { };
            foreach (SentenceToken  sentence in ListOfSentence)
            {
                words.AddRange(sentence.ListOfWord);
            }
            if(words.Where(w=> w.Lemma == lemma).Count()!=0)
            {
                return true;
            }
            return false;
        }
        public override void CalculateValue()
        {
            foreach (var setnence in ListOfSentence)
            {
                base.DoubleValue += setnence.DoubleValue;
            }
            base.DoubleValue = base.DoubleValue / ListOfSentence.Count;
           
        }
    }
}
