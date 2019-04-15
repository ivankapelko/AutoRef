using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRef
{
   public  class WordCounter
    {
        public int CountInAllText { get; set; } = 0;
        public int CountSentenceForThisWord { get; set; } = 0;
        public int CounterParagraphForThisWord { get; set; } = 0;
    }
}
