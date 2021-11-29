using System;

namespace ForditoprogramokBeadando.Automat.Exceptions
{
    /// <summary>
    /// Exception class for throwing automat-related exceptions.
    /// </summary>
    public class AutomatException : Exception
    {
        /// <summary>
        /// Constructor with error message parameter.
        /// </summary>
        /// <param name="errorMsg">Error message about the cause of exception.</param>
        public AutomatException(string errorMsg) : base(errorMsg) {}
    }
}
