namespace FluentSqlQueryBuilder.Enums
{
    /// <summary>
    /// Specifies the different types of SQL query statements.
    /// </summary>
    public enum QueryStatement
    {
        /// <summary>
        /// Indicates no specific statement.
        /// </summary>
        None,

        /// <summary>
        /// Indicates the SELECT statement.
        /// </summary>
        Select,

        /// <summary>
        /// Indicates the INSERT INTO statement.
        /// </summary>
        InsertInto,

        /// <summary>
        /// Indicates the UPDATE statement.
        /// </summary>
        Update,

        /// <summary>
        /// Indicates the DELETE statement.
        /// </summary>
        Delete
    }
}
