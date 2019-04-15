using Accord.MachineLearning;
using AutoRef.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoRef
{
    class TokenGenerator
    {
        static List<ParagraphToken> _paragraphTokens;
        public static Action CalculateValueForSentence;
        public static Action CalculateValueForParagraphs;
        public static Dictionary<string, WordCounter> BagOfLemm;
        public static int SentenceCount { get; set; }
        public static int WordTokenCount { get; set; }
        RemoveStopWords _rsw;
        RusStemmer _rusStemmer;
        public static List<ParagraphToken> ParagraphTokens
        {
            get
            {
                if (_paragraphTokens != null)
                {
                    return _paragraphTokens;
                }
                return new List<ParagraphToken>();
            }

        }
        public TokenGenerator(string text)
        {
            _paragraphTokens = new List<ParagraphToken>();
            SentenceCount = 0;
            WordTokenCount = 0;
            BagOfLemm = new Dictionary<string, WordCounter> { };
            _rsw = new RemoveStopWords(@"e:\магистратура\AutoRef\RusStopWords.txt");
            _rusStemmer = new RusStemmer();
            GenerateParagraphToken(text);
            GenerateSentenceToken();
        }
        private void GenerateParagraphToken(string text)
        {
            string[] paragraphs = GetParagraph(text);
            int i = 1;
            foreach (var paragraph in paragraphs)
            {
                ParagraphToken p = new ParagraphToken
                {
                    TextValue = paragraph,
                    Number = i
                };
                _paragraphTokens.Add(p);
                i++;


            }
        }
        private void GenerateSentenceToken()
        {
            foreach (var paragraph in _paragraphTokens)
            {
                string[] sentence = GetSentences(paragraph.TextValue);
                SentenceCount += sentence.Length;
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (!String.IsNullOrEmpty(sentence[i]))
                    {
                        SentenceToken sentenceToken = new SentenceToken
                        {
                            TextValue = sentence[i]
                        };


                        var words = _rsw.Execute(sentence[i].Tokenize());
                        WordTokenCount += words.Count;
                        for (int j = 0; j < words.Count; j++)
                        {
                            if (!String.IsNullOrEmpty(words[j]))
                            {
                                WordToken wt = new WordToken
                                {
                                    TextValue = words[j],
                                    Lemma = _rusStemmer.Stem(words[j]),
                                    ParagraphNumber = paragraph.Number
                                    //NumberOfSentence = i
                                };
                                sentenceToken.ListOfWord.Add(wt);
                            }
                            if (BagOfLemm.ContainsKey(_rusStemmer.Stem(words[j])))
                            {
                                (BagOfLemm[_rusStemmer.Stem(words[j])] as WordCounter).CountInAllText++;
                                var n = sentenceToken.ListOfWord.Where(w => w.Lemma == _rusStemmer.Stem(words[j])).Count();
                                if (sentenceToken.ListOfWord.Where(w => w.Lemma == _rusStemmer.Stem(words[j])).Count() <= 1)
                                {
                                    BagOfLemm[_rusStemmer.Stem(words[j])].CountSentenceForThisWord++;
                                }

                            }
                            else
                            {
                                BagOfLemm.Add(_rusStemmer.Stem(words[j]), new WordCounter() { CountInAllText = 1, CountSentenceForThisWord = 1, CounterParagraphForThisWord = 1 });
                            }
                            //TODO переделать

                        }
                        paragraph.ListOfSentence.Add(sentenceToken);
                    }
                }
            }
            //CalculateCountSentenceForWordToken();
        }

        /// <summary>
        /// Метод рассчета колличества предложений в которых встречается лемма
        /// </summary>
        //private void CalculateCountSentenceForWordToken()
        //{
        //    List<SentenceToken> sentenceTokens = new List<SentenceToken> { };
        //    foreach (ParagraphToken paragraph in TokenGenerator.ParagraphTokens)
        //    {
        //        sentenceTokens.AddRange(paragraph.ListOfSentence);
        //    }
        //    foreach(string lemm in BagOfLemm.Keys)
        //    {
        //        for (int i = 0; i < sentenceTokens.Count; i++)
        //        {
        //            BagOfLemm[lemm] += sentenceTokens[i].GetCountLemmInSentence(lemm);
        //        }
        //    }

        //}
        public string[] GetSentences(string text)
        {
            string result = string.Join(" ", text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            string[] tochka = { ". ", "? ", "! " };
            string[] sentences = result.Split(tochka, StringSplitOptions.RemoveEmptyEntries);
            return sentences;
        }

        public string[] GetParagraph(string text)
        {
            List<string> result = new List<string> { };
            var paragraphMarker = Environment.NewLine;
            //RemoveTextHeader(text);
            List<string> paragraphs = text.Split(new[] { paragraphMarker },
                                            StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i=0; i<paragraphs.Count;i++)
            {
                if (!paragraphs[i].StartsWithAny(new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" })&&!paragraphs[i].EndsWith(":"))
                {
                    result.Add(paragraphs[i]);
                    //paragraphs.Remove(paragraph);

                }
                if(paragraphs[i].EndsWith(":"))
                {
                    string newParagraph = paragraphs[i];
                    bool flag = true;
                    i++;
                    if (i != 0)
                    {
                        
                        while(flag)
                        {
                            if (Char.IsLetter(paragraphs[i].FirstOrDefault()))
                            {
                                flag = false;
                            }
                            else
                            {
                                newParagraph += Environment.NewLine + paragraphs[i];
                                i++;
                            }
                            
                            
                        }                       
                    }
                    result.Add(newParagraph);
                }

            }
            return result.ToArray();
        }
        private void RemoveTextHeader(string text)
        {
            Regex reg = new Regex("[0 - 9].*\n");
            var resulst = reg.Match(text);
        }
    }
}
