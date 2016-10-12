
namespace Algorithm.Logic.CrossCutting
{
    /// <summary>
    /// Class for any constans using in application
    /// </summary>
    public class Constant
    {
        public const string ErrorValueDefault = "(999, 999)";

        public const string RegexNumbersOnly = "[0-9]";

        public const string RegexInitializeDirection = "^[a-zA-Z]";

        public const string RegexContainSpace = @"[\s]";

        public const string RegexInitializeWithNumber = "^[0-9]";

        public const string RegexCommandInvalid = "[^nNsSlLoOxX0-9]";

        public const string RegexXInsuportedStep = "[xX][0-9]";
        
    }
}
