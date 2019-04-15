using AutoRef.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRef
{

    public partial class TFForm : Form
    {
        Dictionary<string, double> _wordTF;
        DataTable _dataTable;
        public TFForm(/*Dictionary<string,double> wordTF*/)
        {
            InitializeComponent();
            //_wordTF = wordTF;
            CalculateTFForWordToken();
            TokenGenerator.CalculateValueForSentence?.Invoke();
            TokenGenerator.CalculateValueForParagraphs?.Invoke();
            ShowParagraphTokens();
        }

        private void ShowParagraphTokens()
        {
            dataGridView1.Rows.Clear();
            // _panel.Controls.Clear();
            //var list = TokenGenerator.ParagraphTokens.OrderBy(p => p.DoubleValue);
            foreach (ParagraphToken paragrapth in TokenGenerator.ParagraphTokens)
            {
                dataGridView1.Rows.Add(paragrapth.TextValue, paragrapth.DoubleValue);
                //TokenControl control = new TokenControl(paragrapth);
                //control.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
                //control.Dock = DockStyle.Top;
                // _panel.Controls.Add(control);
            }
        }

        private void ShowSentenceTokens()
        {
            //_panel.Controls.Clear();
            dataGridView1.Rows.Clear();
            List<SentenceToken> sentencesList = new List<SentenceToken> { };
            //var list = TokenGenerator.ParagraphTokens.OrderBy(p => p.DoubleValue);
            foreach (ParagraphToken paragrapth in TokenGenerator.ParagraphTokens)
            {
                sentencesList.AddRange(paragrapth.ListOfSentence);

            }
            // var list = sentencesList.OrderBy(s => s.DoubleValue);
            foreach (SentenceToken sentence in sentencesList)
            {
                dataGridView1.Rows.Add(sentence.TextValue, sentence.DoubleValue);
                //TokenControl control = new TokenControl(sentence);
                //control.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
                //control.Dock = DockStyle.Top;
                // _panel.Controls.Add(control);

            }
        }

        private void ShowWordTokens()
        {
            // _panel.Controls.Clear();
            dataGridView1.Rows.Clear();
            List<WordToken> wordTokens = new List<WordToken> { };
            foreach (ParagraphToken paragraph in TokenGenerator.ParagraphTokens)
            {
                //sentenceTokens.AddRange(paragraph.ListOfSentence);
                for (int i = 0; i < paragraph.ListOfSentence.Count; i++)
                    wordTokens.AddRange(paragraph.ListOfSentence[i].ListOfWord);
            }
            var list = wordTokens.GroupBy(w => w.Lemma).Select(g => g.First()).ToList();;
            foreach (WordToken word in list)
            {
                dataGridView1.Rows.Add(String.Format("{0} ({1})", word.TextValue, word.Lemma), word.DoubleValue);
                //TokenControl control = new TokenControl(sentence);
                //control.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
                //control.Dock = DockStyle.Top;
                // _panel.Controls.Add(control);

            }
        }
        private string GetWordTokenFromParagraph(ParagraphToken token)
        {
            string result = String.Empty;
            foreach (var sentence in token.ListOfSentence)
            {
                for (int i = 0; i < sentence.ListOfWord.Count; i++)
                {
                    result += result = String.Format("{0}. {1} ({2})", i, sentence.ListOfWord[i].TextValue, sentence.ListOfWord[i].Lemma)
                        + Environment.NewLine;

                }
            }
            return result;
        }

        private void CalculateTFForWordToken()
        {
            List<WordToken> wordTokens = new List<WordToken> { };
            List<SentenceToken> sentenceTokens = new List<SentenceToken> { };
            foreach (ParagraphToken paragraph in TokenGenerator.ParagraphTokens)
            {
                sentenceTokens.AddRange(paragraph.ListOfSentence);
                for (int i = 0; i < paragraph.ListOfSentence.Count; i++)
                    wordTokens.AddRange(paragraph.ListOfSentence[i].ListOfWord);
            }
            //foreach (ParagraphToken paragrapth in TokenGenerator.ParagraphTokens)
            //{
            foreach (var sentence in sentenceTokens)
            {
                foreach (WordToken wordtoken in sentence.ListOfWord)
                {
                    wordtoken.CountInText = TokenGenerator.BagOfLemm[wordtoken.Lemma].CountInAllText; //wordTokens.Where(w => wordtoken.Lemma == w.Lemma).Count();
                    wordtoken.SentenceCount = TokenGenerator.BagOfLemm[wordtoken.Lemma].CountSentenceForThisWord;//sentenceTokens.Where(w => wordtoken.Lemma == w.Lemma &&
                                                                                                                 //w.NumberOfSentence == wordtoken.NumberOfSentence).Count();
                    var countParagrapth = wordTokens.Where(w => w.ParagraphNumber == wordtoken.ParagraphNumber && w.Lemma == wordtoken.Lemma).Count();
                    wordtoken.DoubleValue = (wordtoken.CountInText / TokenGenerator.WordTokenCount) *
                        Math.Log10(TokenGenerator.ParagraphTokens.Count / countParagrapth);

                }
                //}
            }
        }

        private void _paragraphShowButton_Click(object sender, EventArgs e)
        {
            this.ShowParagraphTokens();
        }

        private void _sentenceShowButton_Click(object sender, EventArgs e)
        {
            this.ShowSentenceTokens();
        }

        private void _wordShowButton_Click(object sender, EventArgs e)
        {
            this.ShowWordTokens();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
        }
    }
}
