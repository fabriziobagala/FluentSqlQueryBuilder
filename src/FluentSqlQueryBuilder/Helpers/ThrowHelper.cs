using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FluentSqlQueryBuilder.Services;

namespace FluentSqlQueryBuilder.Helpers
{
    /// <summary>
    /// Provides helper methods for throwing exceptions.
    /// </summary>
    internal static class ThrowHelper
    {
        /// <summary>
        /// Throws an exception if <paramref name="argument"/> is null.
        /// </summary>
        /// <param name="argument">The reference type argument to validate as non-null.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ThrowIfNull([NotNull] object? argument, string? paramName = null)
        {
            if (argument is null)
            {
                Throw(paramName);
            }
        }

        /// <summary>
        /// Throws an exception if <paramref name="argument"/> is null or empty.
        /// </summary>
        /// <param name="argument">The string argument to validate as non-null and non-empty.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="argument"/> is empty.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ThrowIfNullOrEmpty([NotNull] string? argument, string? paramName = null)
        {
            if (string.IsNullOrEmpty(argument))
            {
                ThrowNullOrEmptyException(argument, paramName);
            }
        }

        /// <summary>
        /// Throws an exception if <paramref name="argument"/> is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="argument">The string argument to validate.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        /// <exception cref="ArgumentNullException"><paramref name="argument"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="argument"/> is empty or consists only of white-space characters.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ThrowIfNullOrWhiteSpace([NotNull] string? argument, string? paramName = null)
        {
            if (string.IsNullOrWhiteSpace(argument))
            {
                ThrowNullOrWhiteSpaceException(argument, paramName);
            }
        }

        [DoesNotReturn]
        private static void Throw(string? paramName) =>
            throw new ArgumentNullException(paramName);

        [DoesNotReturn]
        private static void ThrowNullOrEmptyException(string? argument, string? paramName)
        {
            ThrowIfNull(argument, paramName);
            throw new ArgumentException(SR.Instance.Argument_EmptyString, paramName);
        }

        [DoesNotReturn]
        private static void ThrowNullOrWhiteSpaceException(string? argument, string? paramName)
        {
            ThrowIfNull(argument, paramName);
            throw new ArgumentException(SR.Instance.Argument_EmptyOrWhiteSpaceString, paramName);
        }
    }
}
