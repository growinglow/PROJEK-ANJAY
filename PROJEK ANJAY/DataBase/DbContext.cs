using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;

namespace PROJEK_ANJAY.DataBase
{
    internal class DbContext
    {
        private string _dbHost;
        private string _dbPort;
        private string _dbUser;
        private string _dbPassword;
        private string _dbName;

        public string connStr;

        public DbContext()
        {
            Env.Load();

            _dbHost = Environment.GetEnvironmentVariable("DB_HOST");
            _dbPort = Environment.GetEnvironmentVariable("DB_PORT");
            _dbUser = Environment.GetEnvironmentVariable("DB_USER");
            _dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
            _dbName = Environment.GetEnvironmentVariable("DB_NAME");

            connStr = $"Host={_dbHost};Port={_dbPort};Username={_dbUser};Password={_dbPassword};Database={_dbName}";

        }
    }
}
