using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wordUnscrambler.data;

namespace wordUnscrambler.source
{
    public class WordMatcher
    {
        public List<MatchedWords> Match(string[] scrambleWords, string[] wordList)
        {
            var matchedWords = new List<MatchedWords>();
            foreach (var word in scrambleWords)
            {
                foreach (var match in wordList)
                {
                    if(word.Equals(match, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(word, match));
                    }
                    else
                    {
                        var scrambledWordLower = word.ToLower();
                        var wordLower = match.ToLower();
                        
                        var scrambledWordArray = scrambledWordLower.ToCharArray();
                        var matchWordArray = wordLower.ToCharArray();

                        Array.Sort(scrambledWordArray);
                        Array.Sort(matchWordArray);

                        var sortedScrambledWord = new string(scrambledWordArray);
                        var matchWord = new string(matchWordArray);


                        if (sortedScrambledWord.Equals(matchWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(word, match));
                        }
                    }
                }
            }

            return matchedWords;
        }

        private MatchedWords BuildMatchedWord(string scrambledWord, string word)
        {
            MatchedWords matchedWord = new MatchedWords()
            {
                scrambledWord = scrambledWord,
                word = word
            };

            return matchedWord;
        }
    }
}
