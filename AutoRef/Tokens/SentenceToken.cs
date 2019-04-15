using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRef.Tokens
{
    public class SentenceToken : Token
    {
       
        public SentenceToken()
        {
            TokenGenerator.CalculateValueForSentence += CalculateValue;
        }
        public List<WordToken> ListOfWord { get; set; } = new List<WordToken> { };
        public override void CalculateValue()
        {
            foreach(var word in ListOfWord)
            {
                base.DoubleValue += word.DoubleValue;
            }
            DoubleValue = base.DoubleValue / ListOfWord.Count;
        }
        public int GetCountLemmInSentence (string lemma)
        {
            return ListOfWord.Where(w => w.Lemma == lemma).Count();
        }
    }
}
