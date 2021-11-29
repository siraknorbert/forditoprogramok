using ForditoprogramokBeadando.Automat.Rules;

namespace ForditoprogramokBeadando.FileReaders.Implementations
{
    /// <summary>
    /// Mocked file reader implementation.
    /// </summary>
    public class MockedReader : IFileReader
    {
        public Rule[,] ReadRules(string filePath, string fileName)
        {
            Rule[,] rulesRead = new Rule[Symbols.NonTerminalSymbols.Length, Symbols.TerminalSymbols.Length];
            
            rulesRead[0, 2] = new Rule("CB", "1");
            rulesRead[0, 4] = new Rule("CB", "1");
            rulesRead[1, 0] = new Rule("+CB", "2");
            rulesRead[1, 3] = new Rule("", "3");
            rulesRead[1, 5] = new Rule("", "3");
            rulesRead[2, 2] = new Rule("FD", "4");
            rulesRead[2, 4] = new Rule("FD", "4");
            rulesRead[3, 0] = new Rule("", "6");
            rulesRead[3, 1] = new Rule("*FD", "5");
            rulesRead[3, 3] = new Rule("", "6");
            rulesRead[3, 5] = new Rule("", "6");
            rulesRead[4, 2] = new Rule("(A)", "7");
            rulesRead[4, 4] = new Rule("i", "8");

            return rulesRead;
        }
    }
}
