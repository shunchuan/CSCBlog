using System;
using System.Collections.Generic;
using System.Text;

namespace CSCBlog.Core.Data.MySql
{
    public class ApplicationDbContext: MySQLDatabase
    {
        public ApplicationDbContext(string connectionName)
            : base(connectionName)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext("MySqlConnection");
        }
    }
}
