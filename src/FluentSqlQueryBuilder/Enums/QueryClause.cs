namespace FluentSqlQueryBuilder.Enums
{
    /// <summary>
    /// Specifies the different types of SQL query clauses.
    /// </summary>
    public enum QueryClause
    {
        /// <summary>
        /// Indicates no specific clause.
        /// </summary>
        None,

        /// <summary>
        /// Indicates the FROM clause.
        /// </summary>
        From,

        /// <summary>
        /// Indicates the INNER JOIN clause.
        /// </summary>
        InnerJoin,

        /// <summary>
        /// Indicates the LEFT JOIN clause.
        /// </summary>
        LeftJoin,

        /// <summary>
        /// Indicates the RIGHT JOIN clause.
        /// </summary>
        RightJoin,

        /// <summary>
        /// Indicates the WHERE clause.
        /// </summary>
        Where,

        /// <summary>
        /// Indicates the GROUP BY clause.
        /// </summary>
        GroupBy,

        /// <summary>
        /// Indicates the HAVING clause.
        /// </summary>
        Having,

        /// <summary>
        /// Indicates the ORDER BY clause.
        /// </summary>
        OrderBy,

        /// <summary>
        /// Indicates the LIMIT clause.
        /// </summary>
        Limit
    }
}
