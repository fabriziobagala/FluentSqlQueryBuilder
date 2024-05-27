using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using FluentSqlQueryBuilder.Services;

namespace FluentSqlQueryBuilder.Exceptions
{
    /// <summary>
    /// Represents errors that occur during application execution related to the unavailability of a SQL engine.
    /// </summary>
    [Serializable]
    public class SqlEngineUnavailableException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlEngineUnavailableException"/> class.
        /// </summary>
        public SqlEngineUnavailableException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlEngineUnavailableException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public SqlEngineUnavailableException(string message) : base(message ?? SR.Instance.SqlEngineUnavailableException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlEngineUnavailableException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public SqlEngineUnavailableException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlEngineUnavailableException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected SqlEngineUnavailableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
