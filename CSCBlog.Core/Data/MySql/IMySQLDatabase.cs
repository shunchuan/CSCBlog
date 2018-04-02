using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCBlog.Core.Data.MySql
{
    public interface IMySqlDatabase
    {
        /// <summary>
        /// Executes a non-query MySQL statement
        /// </summary>
        /// <param name="commandText">The MySQL query to execute</param>
        /// <param name="parameters">Optional parameters to pass to the query</param>
        /// <returns>The count of records affected by the MySQL statement</returns>
        int Execute(string commandText, Dictionary<string, object> parameters);


        /// <summary>
        /// Executes a MySQL query that returns a single scalar value as the result.
        /// </summary>
        /// <param name="commandText">The MySQL query to execute</param>
        /// <param name="parameters">Optional parameters to pass to the query</param>
        /// <returns></returns>
        object QueryValue(string commandText, Dictionary<string, object> parameters);

        /// <summary>
        /// Executes a SQL query that returns a list of rows as the result.
        /// </summary>
        /// <param name="commandText">The MySQL query to execute</param>
        /// <param name="parameters">Parameters to pass to the MySQL query</param>
        /// <returns>A list of a Dictionary of Key, values pairs representing the 
        /// ColumnName and corresponding value</returns>
        List<Dictionary<string, string>> Query(string commandText, Dictionary<string, object> parameters);

        /// <summary>
        /// Helper method to return query a string value 
        /// </summary>
        /// <param name="commandText">The MySQL query to execute</param>
        /// <param name="parameters">Parameters to pass to the MySQL query</param>
        /// <returns>The string value resulting from the query</returns>
        string GetStrValue(string commandText, Dictionary<string, object> parameters);

        void Dispose();
    }
}
