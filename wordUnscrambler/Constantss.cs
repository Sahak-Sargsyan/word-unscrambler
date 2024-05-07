using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordUnscrambler
{
    public class Constantss
    {
        public const string OptionsToEnter = "Enter scrumbled word(s): manually - M / as a file - F: ";
        public const string ContinueOrNo = "Would You like to Continue - Y/N: ";

        public const string EnterviaFile = "Enter full path of file including the name of file: ";
        public const string EnterManually = "Enter Words Manually (separeted by ','): ";
        public const string OptionNotRecognized = "The option was not recognized: ";

        public const string ScrambledWordsCanNotBeLoaded = "Scrambled words can not be loaded (incorrect path or file doesn't exist): ";
        public const string ProgramWillBeTerminated = "Program will be terminated: ";

        public const string MatchFound = "Match Found for {0}: {1}";
        public const string MatchNotFound = "No matches have been found";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string WordsFileName = "words.txt";
    }
}
