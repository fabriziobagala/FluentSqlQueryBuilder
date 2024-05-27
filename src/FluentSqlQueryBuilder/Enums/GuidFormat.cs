namespace FluentSqlQueryBuilder.Enums
{
    /// <summary>
    /// Specifies the format for GUID (Globally Unique Identifier) values in SQL queries.
    /// </summary>
    public enum GuidFormat
    {
        /// <summary>
        /// Indicates that GUIDs should be represented as 32 contiguous digits: 00000000000000000000000000000000
        /// </summary>
        Numeric,

        /// <summary>
        /// Indicates that GUIDs should be represented as as 32 digits separated by hyphens: 00000000-0000-0000-0000-000000000000
        /// </summary>
        Hyphenated,

        /// <summary>
        /// Indicates that GUIDs should be represented as 32 digits separated by hyphens and enclosed in braces: {00000000-0000-0000-0000-000000000000}
        /// </summary>
        Braced,

        /// <summary>
        /// Indicates that GUIDs should be represented as 32 digits separated by hyphens and enclosed in parentheses: (00000000-0000-0000-0000-000000000000)
        /// </summary>
        Parentheses,

        /// <summary>
        /// Indicates that GUIDs should be represented as four hexadecimal values enclosed in braces, where the fourth value is a subset of eight 
        /// hexadecimal values that is also enclosed in braces: {0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}}
        /// </summary>
        Hexadecimal
    }
}
