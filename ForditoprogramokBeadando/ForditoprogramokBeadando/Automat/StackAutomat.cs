using ForditoprogramokBeadando.Automat.InputProcessing;
using ForditoprogramokBeadando.Automat.Rules;
using ForditoprogramokBeadando.FileReaders;
using ForditoprogramokBeadando.FileReaders.Implementations;

namespace ForditoprogramokBeadando.Automat
{
    /// <summary>
    /// Automat that wraps input processing handler, file reader and rule handler.
    /// Input processing handled, files read and rules defined through a singleton instance of this class.
    /// </summary>
    public class StackAutomat
    {
        /// <summary>
        /// Singleton instance of this class.
        /// </summary>
        private static StackAutomat singletonInstance;

        /// <summary>
        /// Method to initialize and / or return singleton instance of [Automat] class.
        /// </summary>
        /// <returns>Singleton instance of [Automat] class.</returns>
        public static StackAutomat SingletonInstance()
        {
            if (singletonInstance is null)
            {
                singletonInstance = new StackAutomat();
            }
            return singletonInstance;
        }

        /// <summary>
        /// Matrix of input operation rules.
        /// </summary>
        private Rule[,] rules;

        /// <summary>
        /// Property for matrix that contains input operation rules.
        /// </summary>
        public Rule[,] Rules { get; set; }

        /// <summary>
        /// A file reader implementation instance.
        /// </summary>
        private IFileReader fileReader;

        /// <summary>
        /// Property of file reader implementation.
        /// </summary>
        public IFileReader FileReader { private get; set; }


        /// <summary>
        /// No args constructor.
        /// </summary>
        private StackAutomat()
        {
            FileReader = new MockedReader();
            ReadRules("", "");
        }

        /// <summary>
        /// Create input handler and delegate to it's processing method.
        /// </summary>
        /// <param name="input">Full input tape.</param>
        public string ValidateInput(string input)
        {
            InputValidator inputValidator = new InputValidator(input, Rules);
            inputValidator.ValidateInput();
            return inputValidator.ToString();
        }

        /// <summary>
        /// Read and set rules.
        /// </summary>
        /// <param name="path">Optional path to file.</param>
        public void ReadRules(string path, string file)
        {
            Rules = FileReader.ReadRules(path, file);
        }
    }
}
