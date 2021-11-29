using System;

namespace ForditoprogramokBeadando.Automat.Exceptions
{
    /// <summary>
    /// Exception class for throwing input-related exceptions.
    /// </summary>
    public class InputException : AutomatException
    {
        /// <summary>
        /// Constructor with error message parameter.
        /// </summary>
        /// <param name="errorMsg">Error message about the cause of exception.</param>
        public InputException(string errorMsg) 
            : base(String.Format("Input error: {0}", errorMsg)) {}
    }
}
