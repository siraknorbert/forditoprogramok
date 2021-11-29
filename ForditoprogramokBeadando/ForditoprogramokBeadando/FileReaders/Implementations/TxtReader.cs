using ForditoprogramokBeadando.Automat.Rules;
using System;
using System.IO;
using System.Text;

namespace ForditoprogramokBeadando.FileReaders.Implementations
{
    /// <summary>
    /// Csv file reader implementation.
    /// </summary>
    class TxtReader : IFileReader
    {
        public Rule[,] ReadRules(string filePath, string fileName)
        {
            Rule[,] rulesRead = new Rule[Symbols.NonTerminalSymbols.Length, Symbols.TerminalSymbols.Length];

            StreamReader streamReader = new StreamReader(filePath + "\\" + fileName, Encoding.Default);
            streamReader.ReadLine();

            while (!streamReader.EndOfStream)
            {
                string[] data = streamReader.ReadLine().Split(';');
                rulesRead[int.Parse(data[0]), int.Parse(data[1])] = new Rule(data[2].ToString(), data[3].ToString());
            }
            streamReader.Close();

            return rulesRead;
        }
    }
}
