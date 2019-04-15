using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRef.Tokens
{
    public abstract class Token
    {
        public string TextValue { get; set; }
        public double  DoubleValue { get; set; }
        public virtual void CalculateValue()
        {
        }
        
        public TokenType TypeOfToken { get; set; }
    }

    public enum TokenType
    {
        WordToken,
        SentenceToken,
        PoragraphToken
    }
}
