using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoRef.Tokens;

namespace AutoRef
{
    public partial class TokenControl : UserControl
    {
        public string TextValue{get;set;}
        public double DoubleValue { get; set; }
        public TokenControl(Token token)
        {
            InitializeComponent();
            TextValue = token.TextValue;
            DoubleValue = token.DoubleValue;
            _paragraphText.Text = TextValue;
            _tokenValue.Text = DoubleValue.ToString("F5");

        }

    }
}
