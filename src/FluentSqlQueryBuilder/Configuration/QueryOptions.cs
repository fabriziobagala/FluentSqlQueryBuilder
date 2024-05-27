using System.Globalization;
using FluentSqlQueryBuilder.Enums;

namespace FluentSqlQueryBuilder.Configuration
{
    /// <summary>
    /// Provides options for configuring the behavior of the query builder.
    /// </summary>
    public class QueryOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether a semicolon should be appended at the end of the query. 
        /// The default value is <see langword="true"/>.
        /// </summary>
        public bool AppendSemicolon { get; set; } = true;

        /// <summary>
        /// Gets or sets the culture to use for messages localized to the user's language. 
        /// The default value is <see cref="en-US"/>.
        /// </summary>
        public CultureInfo Culture { get; set; } = new CultureInfo("en-US");

        /// <summary>
        /// Gets or sets the format to use for <see cref="DateTime"/> values. 
        /// The default value is "yyyy-MM-dd HH:mm:ss".
        /// </summary>
        public string DateTimeFormat { get; set; } = "yyyy-MM-dd HH:mm:ss";

        /// <summary>
        /// Gets or sets the format to use for <see cref="DateTimeOffset"/> values. 
        /// The default value is "yyyy-MM-dd HH:mm:ss zzz".
        /// </summary>
        public string DateTimeOffsetFormat { get; set; } = "yyyy-MM-dd HH:mm:ss zzz";

        /// <summary>
        /// Gets or sets the storage format to use for enum values. 
        /// The default value is <see cref="EnumStorageFormat.Int32"/>.
        /// </summary>
        public EnumStorageFormat EnumStorageFormat { get; set; } = EnumStorageFormat.Int32;

        /// <summary>
        /// Gets or sets the format to use for GUIDs. 
        /// The default value is <see cref="GuidFormat.Hyphenated"/>.
        /// </summary>
        public GuidFormat GuidFormat { get; set; } = GuidFormat.Hyphenated;

        /// <summary>
        /// Gets or sets a value indicating whether to ignore null values when building queries. 
        /// The default value is <see langword="true"/>.
        /// </summary>
        public bool IgnoreNullValues { get; set; } = true;

        /// <summary>
        /// Gets or sets the SQL database engine to use. 
        /// The default value is <see cref="SqlEngine.MySQL"/>.
        /// </summary>
        public SqlEngine SqlEngine { get; set; } = SqlEngine.MySQL;

        /// <summary>
        /// Gets or sets the SQLServer compatibility level to use.
        /// This is only applicable when <see cref="SqlEngine"/> is set to <see cref="SqlEngine.SqlServer"/>. 
        /// The default value is <see cref="SqlServerCompatibilityLevel.SqlServer2016"/>.
        /// </summary>
        public SqlServerCompatibilityLevel SqlServerCompatibilityLevel { get; set; } = SqlServerCompatibilityLevel.SqlServer2016;
    }
}
