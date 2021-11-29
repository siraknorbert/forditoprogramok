using System;

namespace ForditoprogramokBeadando.Automat.Exceptions
{
    /// <summary>
    /// Exception class for throwing rule-related exceptions.
    /// </summary>
    public class RuleException : AutomatException
    {
        /// <summary>
        /// Constructor with error message parameter.
        /// </summary>
        /// <param name="errorMsg">Error message about the cause of exception.</param>
        public RuleException(string errorMsg)
            : base(String.Format("Rule error: {0}", errorMsg)) { }
    }
}
