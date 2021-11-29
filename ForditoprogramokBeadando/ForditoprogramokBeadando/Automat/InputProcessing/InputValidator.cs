using ForditoprogramokBeadando.Automat.Exceptions;
using ForditoprogramokBeadando.Automat.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ForditoprogramokBeadando.Automat.InputProcessing
{
    /// <summary>
    /// Class that handles the states of input processing.
    /// One instance of this class can perform one single validation.
    /// </summary>
    public class InputValidator
    {
        /// <summary>
        /// Rules to process by.
        /// </summary>
        private readonly Rule[,] rules;

        /// <summary>
        /// Stack of states. Last-in is the current state.
        /// </summary>
        private Stack<InputValidationState> states;

        /// <summary>
        /// Bool that will be true if accept state is reached during validation.
        /// </summary>
        private bool acceptStateReached;

        /// <summary>
        /// Initializing input validator.
        /// </summary>
        /// <param name="input">Input to validate.</param>
        /// <param name="rules">Rules to operate by during validation.</param>
        public InputValidator(string input, Rule[,] rules)
        {
            this.rules = rules;
            acceptStateReached = false;
            ValidateInputCharacters(input);
            input = Regex.Replace(input, @"\d", "i");
            states = new Stack<InputValidationState>();
            states.Push(new InputValidationState(input + Symbols.AcceptSymbol, "A" + Symbols.AcceptSymbol, "e"));
        }

        /// <summary>
        /// Processes of input validation and changing states recursively.
        /// </summary>
        /// <param name="rules">Matrix of state change rules.</param>
        public void ValidateInput()
        {
            InputValidationState currentState = states.Peek();
            string currentStateFirstCharacter = currentState.GetFirstCharacterOfInputSection();
            string currentStateTopRule = currentState.GetFirstRule();

            string nextStateInputSectionTape = currentState.InputSectionTape;
            string nextStateRulesTape = currentState.RulesTape.Substring(1);
            string nextStateRuleNumbersTape = currentState.RuleNumbersTape;

            if (Equals(currentStateFirstCharacter, currentStateTopRule))
            {
                if (Equals(currentStateFirstCharacter, Symbols.AcceptSymbol))
                {
                    acceptStateReached = true;
                }
                nextStateInputSectionTape = nextStateInputSectionTape.Substring(1);
            }
            else
            {
                int ruleColumnIndex = GetRuleColumnIndex(currentStateFirstCharacter);
                if (ruleColumnIndex < 0)
                {
                    throw new InputException(
                        String.Format("First character of input tape is invalid: '{0}'.", currentStateFirstCharacter));
                }

                int ruleRowIndex = GetRuleRowIndex(currentStateTopRule);
                if (ruleRowIndex < 0)
                {
                    throw new RuleException(
                        String.Format("First rule of rules tape is invalid: '{0}'.", currentStateTopRule));
                }

                Rule tapesExtension = rules[ruleRowIndex, ruleColumnIndex];
                if (tapesExtension is null)
                {
                    throw new InputException("Invalid input character sequence.");
                }

                nextStateRulesTape = tapesExtension.Symbol + nextStateRulesTape;
                nextStateRuleNumbersTape = nextStateRuleNumbersTape + tapesExtension.Number;
            }

            if (acceptStateReached is false)
            {
                states.Push(new InputValidationState(nextStateInputSectionTape, nextStateRulesTape, nextStateRuleNumbersTape));
                ValidateInput();
            }
        }

        /// <summary>
        /// Function that returns the column index of the first character read.
        /// </summary>
        /// <param name="firstCharacter">First character of current input segment.</param>
        /// <returns>Index of rule column, or -1 if there was no symbol found.</returns>
        public int GetRuleColumnIndex(string firstCharacter)
        {
            for (int i = 0; i < Symbols.TerminalSymbols.Length; i++)
            {
                if (firstCharacter == Symbols.TerminalSymbols[i])
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Function that returns the row index of the top rule popped.
        /// </summary>
        /// <param name="topRule">Top rule of the stack of processing state rules.</param>
        /// <returns>Index of rule row, or -1 if there was no symbol found.</returns>
        public int GetRuleRowIndex(string topRule)
        {
            for (int i = 0; i < Symbols.NonTerminalSymbols.Length; i++)
            {
                if (topRule == Symbols.NonTerminalSymbols[i])
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Returns the input processing states as string.
        /// </summary>
        /// <returns>String that contains: states with line breaks between them.</returns>
        public override string ToString()
        {
            StringBuilder statesStringBuilder = new StringBuilder();

            for (int i = states.Count - 1; i >= 0; i--)
            {
                statesStringBuilder.Append(String.Format("--> {0}\n", states.ElementAt(i).ToString()));
            }

            return statesStringBuilder.ToString();
        }

        /// <summary>
        /// Method that checks if input contains only valid characters.
        /// </summary>
        /// <param name="input">Input tape.</param>
        /// <param name="validFrom">First valid number. 0 by default.</param>
        /// <param name="validTo">Last valid number. 10 by default.</param>
        private void ValidateInputCharacters(string input, int validFrom = 0, int validTo = 10)
        {
            int validCharactersLength = Symbols.TerminalSymbols.Length + validTo - validFrom;
            string[] validCharacters = new string[validCharactersLength];

            // numbers from [validFrom] to [validTo] are valid
            for (int i = validFrom; i < validTo; i++)
            {
                validCharacters[i] = i.ToString();
            }

            // terminal symbols are valid
            for (int i = validTo; i < validCharactersLength; i++)
            {
                validCharacters[i] = Symbols.TerminalSymbols[i - validTo];
            }

            // check if there is any invalid input character
            bool isCharacterValid;
            for (int inputIndex = 0; inputIndex < input.Length; inputIndex++)
            {
                isCharacterValid = false;

                for (int validationIndex = 0; validationIndex < validCharacters.Length; validationIndex++)
                {
                    if (Equals(input[inputIndex].ToString(), validCharacters[validationIndex]))
                    {
                        isCharacterValid = true;
                        break;
                    }
                }

                if (isCharacterValid is false)
                {
                    throw new InputException(String.Format("Invalid input character: '{0}'!", input[inputIndex]));
                }
            }
        }
    }
}
