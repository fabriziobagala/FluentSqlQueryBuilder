using System.ComponentModel;
using FluentSqlQueryBuilder.Enums;
using FluentSqlQueryBuilder.Exceptions;

namespace FluentSqlQueryBuilder.Data.SqlParser
{
    /// <summary>
    /// Factory class for creating SQL parsers based on the SQL engine.
    /// </summary>
    internal sealed class SqlParserFactory
    {
        /// <summary>
        /// Returns a SQL parser for the given SQL engine.
        /// </summary>
        /// <param name="sqlEngine">The SQL engine for which to return a parser.</param>
        /// <returns>A SQL parser for the given SQL engine.</returns>
        /// <exception cref="SqlEngineUnavailableException">Thrown when a parser for the given SQL engine is not available.</exception>
        /// <exception cref="InvalidEnumArgumentException">Thrown when an unsupported <see cref="SqlEngine"/> is provided.</exception>
        internal ISqlParser GetParser(SqlEngine sqlEngine) => sqlEngine switch
        {
            SqlEngine.MySQL => new MySqlParser(),
            SqlEngine.PostgreSQL => throw new SqlEngineUnavailableException(),
            SqlEngine.SQLite => throw new SqlEngineUnavailableException(),
            SqlEngine.SQLServer => throw new SqlEngineUnavailableException(),
            _ => throw new InvalidEnumArgumentException(nameof(sqlEngine), (int)sqlEngine, typeof(SqlEngine))
        };
    }
}
