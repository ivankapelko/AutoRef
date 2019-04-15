using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRef.Tokens
{
    public class WordToken : Token
    {
        /// <summary>
        /// Количество предложений в которых встречается Лемма
        /// </summary>
       // public int CountSentence { get; set; }
        public string Lemma { get; set; }
        /// <summary>
        /// Сколько раз токен встрачается в тексте
        /// </summary>
        public double CountInText { get; set; }
        public int ParagraphNumber { get; set; }
        public double SentenceCount { get; set; }
        public override void CalculateValue()
        {
            base.CalculateValue();
        }
    }
}
