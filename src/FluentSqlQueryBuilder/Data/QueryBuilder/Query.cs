using System;
using System.Text;
using FluentSqlQueryBuilder.Configuration;
using FluentSqlQueryBuilder.Data.SqlParser;
using FluentSqlQueryBuilder.Enums;
using FluentSqlQueryBuilder.Services;

namespace FluentSqlQueryBuilder.Data.QueryBuilder
{
    /// <summary>
    /// Represents a builder for SQL queries.
    /// </summary>
    public partial class Query
    {
        private readonly QueryOptions _options;
        private readonly ISqlParser _sqlParser;
        
        private StringBuilder _queryBuilder = new StringBuilder();
        private QueryStatement _statement = QueryStatement.None;
        private QueryClause _clause = QueryClause.None;

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class with the <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for building the query. If null, the default options are used.</param>
        public Query(QueryOptions? options = null)
        {
            _options = options ?? new QueryOptions();

            _sqlParser = new SqlParserFactory()
                .GetParser(_options.SqlEngine);

            SR.Initialize(_options.Culture);
        }

        /// <summary>
        /// Builds the SQL query and returns it as a string.
        /// </summary>
        /// <returns>The SQL query as a string.</returns>
        public string Build()
        {
            if (_options.AppendSemicolon)
            {
                _queryBuilder.Append(';');
            }
            
            return _queryBuilder.ToString();
        }

        /// <summary>
        /// Creates a new <see cref="Query"/> object that is a deep copy of the current instance.
        /// </summary>
        /// <returns>A new <see cref="Query"/> object that is a deep copy of this instance.</returns>
        public Query Clone() => new Query(_options)
        {
            _queryBuilder = new StringBuilder(_queryBuilder.ToString()),
            _statement = _statement,
            _clause = _clause
        };

        /// <summary>
        /// Executes one of two functions based on a condition.
        /// </summary>
        /// <param name="condition">The condition to evaluate.</param>
        /// <param name="whenTrue">The function to execute if the condition is <see langword="true"/>.</param>
        /// <param name="whenFalse">The function to execute if the condition is <see langword="false"/>.</param>
        /// <returns>The result of executing the function.</returns>
        public Query When(bool condition, Func<Query, Query> whenTrue, Func<Query, Query> WhenFalse) => 
            condition ? whenTrue(this) : WhenFalse(this);
    }
}
