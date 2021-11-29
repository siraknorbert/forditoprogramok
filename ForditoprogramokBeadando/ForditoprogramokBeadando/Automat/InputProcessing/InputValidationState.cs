using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForditoprogramokBeadando.Automat.InputProcessing
{
    /// <summary>
    /// An instance of this class contains a concrete state of input processing.
    /// </summary>
    public class InputValidationState
    {
        /// <summary>
        /// A section of the input tape.
        /// </summary>
        private readonly string inputSectionTape;
        public string InputSectionTape { get; private set; }

        /// <summary>
        /// Rules stored as string.
        /// </summary>
        private readonly string rulesTape;
        public string RulesTape { get; private set; }

        /// <summary>
        /// Concatenated numbers of rules that were already used as string.
        /// </summary>
        private readonly string ruleNumbersTape;
        public string RuleNumbersTape { get; private set; }

        /// <summary>
        /// All-args constructor
        /// </summary>
        /// <param name="inputSectionTape">Contains the full input tape or a section of it.</param>
        /// <param name="rulesTape">Contains the tape of the rules.</param>
        /// <param name="ruleNumbersTape">Contains the tape of rule numbers.</param>
        public InputValidationState(string inputSectionTape, string rulesTape, string ruleNumbersTape)
        {
            InputSectionTape = inputSectionTape;
            RulesTape = rulesTape;
            RuleNumbersTape = ruleNumbersTape;
        }

        /// <summary>
        /// Uses substring method on the input section to get its' first character.
        /// </summary>
        /// <returns>First character of the input section.</returns>
        public string GetFirstCharacterOfInputSection()
        {
            return InputSectionTape.Substring(0, 1);
        }

        /// <summary>
        /// Return the first rule.
        /// </summary>
        /// <returns>First character at the beginning of rules tape.</returns>
        public string GetFirstRule()
        {
            return RulesTape.Substring(0, 1);
        }

        /// <summary>
        /// Returns the input processing state as string.
        /// </summary>
        /// <returns>String that contains: tapes of instance.</returns>
        public override string ToString()
        {
            return String.Format("( {0}, {1}, {2} )", InputSectionTape, RulesTape, RuleNumbersTape);
        }
    }
}
