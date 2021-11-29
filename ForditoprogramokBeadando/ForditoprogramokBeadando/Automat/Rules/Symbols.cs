
namespace ForditoprogramokBeadando.Automat.Rules
{
    /// <summary>
    /// Contains terminal and non-terminal symbols.
    /// </summary>
    public static class Symbols
    {
        /* ----------------------------------
         *    INDEXES IN MATRIX OF RULES
         * ----------------------------------
         * Non-terminal symbols - row indexes
         *   "A"  - 0
         *   "B'" - 1
         *   "C"  - 2
         *   "D'" - 3
         *   "F"  - 4
         * ----------------------------------
         * Terminal symbols - column indexes
         *   "+"  - 0
         *   "*"  - 1
         *   "("  - 2
         *   ")"  - 3
         *   "i"  - 4
         *   "#"  - 5
         * ----------------------------------
         */

        /// <summary>
        /// Array that contains the non-terminal symbols.
        /// </summary>
        public static readonly string[] NonTerminalSymbols = new string[] { "A", "B", "C", "D", "F" };

        /// <summary>
        /// Array that contains the terminal symbols.
        /// </summary>
        public static readonly string[] TerminalSymbols = new string[] { "+", "*", "(", ")", "i", "#" };

        /// <summary>
        /// Accept symbol. It is the last terminal symbol.
        /// </summary>
        public static readonly string AcceptSymbol = TerminalSymbols[TerminalSymbols.Length - 1];
    }
}
