namespace FluentSqlQueryBuilder.Enums
{
    /// <summary>
    /// Specifies the compatibility level for SQL Server.
    /// </summary>
    public enum SqlServerCompatibilityLevel
    {
        /// <summary>
        /// Indicates the SQL Server 2000 (8.x) compatibility level.
        /// </summary>
        SqlServer2000 = 80,

        /// <summary>
        /// Indicates the SQL Server 2005 (9.x) compatibility level.
        /// </summary>
        SqlServer2005 = 90,

        /// <summary>
        /// Indicates the SQL Server 2008 (10.x) compatibility level.
        /// </summary>
        SqlServer2008 = 100,

        /// <summary>
        /// Indicates the SQL Server 2012 (11.x) compatibility level.
        /// </summary>
        SqlServer2012 = 110,

        /// <summary>
        /// Indicates the SQL Server 2014 (12.x) compatibility level.
        /// </summary>
        SqlServer2014 = 120,

        /// <summary>
        /// Indicates the SQL Server 2016 (13.x) compatibility level.
        /// </summary>
        SqlServer2016 = 130,

        /// <summary>
        /// Indicates the SQL Server 2017 (14.x) compatibility level.
        /// </summary>
        SqlServer2017 = 140,

        /// <summary>
        /// Indicates the SQL Server 2019 (15.x) compatibility level.
        /// </summary>
        SqlServer2019 = 150,

        /// <summary>
        /// Indicates the SQL Server 2022 (16.x) compatibility level.
        /// </summary>
        SqlServer2022 = 160
    }
}
