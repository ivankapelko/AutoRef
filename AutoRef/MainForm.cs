using Accord.MachineLearning;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Fitting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AutoRef
{
    public partial class MainForm : Form
    {
        private string[] _allWords;
        private List<string> _wordsWithOutStopWords;
        private Dictionary<string, double> _wordCount;
        public MainForm()
        {
            InitializeComponent();
            _allWords = new string[] { };
            _wordsWithOutStopWords = new List<string> { };
            _wordCount = new Dictionary<string, double> { };

        }



        private void _openFile_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string s = File.ReadAllText(_openFileDialog.FileName);
                _richTextBox.Text = s;
                TokenGenerator tokenGenerator = new TokenGenerator(s);
                _allWords = s.Tokenize();
                RemoveStopWords rsw = new RemoveStopWords(@"e:\магистратура\AutoRef\RusStopWords.txt");
                CountWord.Text = "Количество слов в документе: " + _allWords.Length.ToString();
               // _wordsWithOutStopWords = rsw.Execute(_allWords.ToList());
            }

        }

        private void _culculateTF_Click(object sender, EventArgs e)
        {
            CalculateTermFrequency();
        }
        private void CalculateTermFrequency()
        {
            //_wordsWithOutStopWords.Add(String.Empty);
            //for (int i = 0; i < _wordsWithOutStopWords.Count - 1; i++)
            //{
            //    if (_wordsWithOutStopWords[i] != String.Empty)
            //    {
            //        _wordCount.Add(_wordsWithOutStopWords[i], 1);
            //        for (int j = i + 1; j < _wordsWithOutStopWords.Count; j++)
            //        {
            //            if (_wordsWithOutStopWords[i] == _wordsWithOutStopWords[j])
            //            {
            //                _wordCount[_wordsWithOutStopWords[i]] += 1;
            //                _wordsWithOutStopWords[j] = String.Empty;
            //            }
            //        }
            //        _wordCount[_wordsWithOutStopWords[i]] = _wordCount[_wordsWithOutStopWords[i]] / _wordsWithOutStopWords.Count;
            //        _wordsWithOutStopWords[i] = String.Empty;
            //    }
            //}
            TFForm tfForm = new TFForm();
            tfForm.ShowDialog();
        }
    }
}
