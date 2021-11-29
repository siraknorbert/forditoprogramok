using ForditoprogramokBeadando.Automat.Rules;

namespace ForditoprogramokBeadando.FileReaders
{
    /// <summary>
    /// Interface that defines the behaviour of file reader classes.
    /// These classes are used to read input operation rules from various kinds of external files.
    /// </summary>
    public interface IFileReader
    {
        /// <summary>
        /// Method that reads input operation rules.
        /// </summary>
        /// <param name="filePath">Contains path to external file.</param>
        /// <param name="fileName">Name of external file.</param>
        /// <returns>Matrix of rules read.</returns>
        Rule[,] ReadRules(string filePath, string fileName);
    }
}
