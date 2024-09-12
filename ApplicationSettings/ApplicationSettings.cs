namespace ApplicationSettings
{
    public class ApplicationSettings
    {
        private string _programName;
        private string _programVersion;

        public ApplicationSettings()
        {
            _programName = "Program Name";
            _programVersion = "v2.0";
            var dbSettings = new DatabaseSettings("connection string");
        }

        public class DatabaseSettings
        {
            private string _dbConnection;
            private TimeOnly _timeout;
            public DatabaseSettings(string connection)
            {
                _dbConnection = connection;
                _timeout = new TimeOnly(5000);
            }
        }
    }
}