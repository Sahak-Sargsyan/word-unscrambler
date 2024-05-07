using wordUnscrambler.source;
using wordUnscrambler.data;
using wordUnscrambler;

public class Program
{
    private static readonly FileReader _fileReader = new FileReader();
    private static readonly WordMatcher _wordMatcher = new WordMatcher();

    public static void Main(string[] args)
    {
        bool wordUnscrambled = true;

        try
        {
            do
            {
                Console.WriteLine(Constantss.OptionsToEnter);
                string option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case Constantss.File:
                        Console.Write(Constantss.EnterviaFile);
                        ScrambleWordFile();
                        break;

                    case Constantss.Manual:
                        Console.Write(Constantss.EnterManually);
                        ScrambleWordManual();
                        break;

                    default:
                        Console.WriteLine(Constantss.OptionNotRecognized);
                        break;
                }

                var continueDecision = string.Empty;
                do
                {
                    Console.WriteLine(Constantss.ContinueOrNo);
                    continueDecision = Console.ReadLine() ?? string.Empty;
                } while (!continueDecision.Equals(Constantss.Yes, StringComparison.OrdinalIgnoreCase) &&
                         !continueDecision.Equals(Constantss.No, StringComparison.OrdinalIgnoreCase));

                wordUnscrambled = continueDecision.Equals(Constantss.Yes, StringComparison.OrdinalIgnoreCase);

            } while (wordUnscrambled);
        }
        catch (Exception ex)
        {

            Console.WriteLine(Constantss.ProgramWillBeTerminated + ex.Message);
        }
    }

    private static void ScrambleWordManual()
    {
        var manual = Console.ReadLine() ?? string.Empty;
        string[] scrambleWords = manual.Split(',');
        DisplayMatchedOnes(scrambleWords);
    }

    private static void ScrambleWordFile()
    {
        try
        {
            var fileName = Console.ReadLine() ?? string.Empty;
            string[] scrambleWords = _fileReader.Read(fileName);
            DisplayMatchedOnes(scrambleWords);
        }
        catch (Exception ex)
        {
            Console.WriteLine(Constantss.ScrambledWordsCanNotBeLoaded + ex.Message);
        }
        
    }

    private static void DisplayMatchedOnes(string[] scrambleWords)
    {
        string[] wordList = _fileReader.Read(Constantss.WordsFileName);

        List<MatchedWords> matchedOnes = _wordMatcher.Match(scrambleWords, wordList);

        if (matchedOnes.Any())
        {
            foreach (var word in matchedOnes)
            {
                Console.WriteLine(Constantss.MatchFound, word.scrambledWord, word.word);
            }
        }
        else
        {
            Console.WriteLine(Constantss.MatchNotFound);
        }
    }
}



