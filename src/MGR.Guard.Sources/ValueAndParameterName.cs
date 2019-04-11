namespace MGR.Guard
{
    /// <summary>
    /// Encapsulate the value and the parameter name extracted from an expression.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    public struct ValueAndParameterName<T>
    {
        /// <summary>
        /// Gets the value extracted from an expression.
        /// </summary>
        public T Value { get; }
        /// <summary>
        /// Gets the parameter name extracted from an expression.
        /// </summary>
        public string ParameterName { get; }

        internal ValueAndParameterName(T value, string parameterName)
        {
            Value = value;
            ParameterName = parameterName;
        }
        /// <summary>
        /// Deconstruct this instance. Used by C# compiler.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">The parameter name.</param>
        public void Deconstruct(out T value, out string parameterName)
        {
            value = Value;
            parameterName = ParameterName;
        }
    }
}