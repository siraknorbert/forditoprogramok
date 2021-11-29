
namespace ForditoprogramokBeadando.Automat.Rules
{
    /// <summary>
    /// Class that defines a rule the Automat changes state by.
    /// </summary>
    public class Rule
    {
        /// <summary>
        /// Rule to add.
        /// </summary>
        private string symbol;

        /// <summary>
        /// Rule to add property.
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Number of rule as string.
        /// </summary>
        private string number;

        /// <summary>
        /// Number of rule as string property.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// All-args constructor.
        /// </summary>
        /// <param name="symbol">Rule's symbol.</param>
        /// <param name="number">Rule's number.</param>
        public Rule(string symbol, string number)
        {
            Symbol = symbol;
            Number = number;
        }

        /// <summary>
        /// Rule to string override.
        /// </summary>
        /// <returns>Symbol and number as string.</returns>
        public override string ToString()
        {
            return string.Format("( {0}, {1} )", Symbol, Number);
        }
    }
}
