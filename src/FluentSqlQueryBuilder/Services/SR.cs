using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using FluentSqlQueryBuilder.Helpers;

namespace FluentSqlQueryBuilder.Services
{
    /// <summary>
    /// Provides a service for retrieving localized string resources.
    /// </summary>
    internal sealed class SR
    {
        private const string MessagesPath = "FluentSqlQueryBuilder.Resources.Messages";

        private static Lazy<SR>? _lazy;
        private readonly CultureInfo _culture;

        internal static SR Instance => _lazy!.Value;

        private static readonly Assembly _assembly = typeof(SR).Assembly;
        private static readonly ResourceManager _resourceManager = new ResourceManager(MessagesPath, _assembly);

        private SR(CultureInfo culture)
        {
            _culture = culture;
        }

        /// <summary>
        /// Initializes the SR class with the <paramref name="culture"/>
        /// </summary>
        /// <param name="culture">The culture to use when retrieving resources.</param>
        internal static void Initialize(CultureInfo culture)
        {
            _lazy = new Lazy<SR>(() => new SR(culture));
        }

        internal string SqlEngineUnavailableException => GetResourceString("SqlEngineUnavailableException");

        internal string Argument_EmptyString => GetResourceString("Argument_EmptyString");
        internal string Argument_EmptyOrWhiteSpaceString => GetResourceString("Argument_EmptyOrWhiteSpaceString");

        private string GetResourceString(string resourceName)
        {
            ThrowHelper.ThrowIfNullOrWhiteSpace(resourceName);

            return _resourceManager.GetString(resourceName, _culture)!;
        }
    }
}
