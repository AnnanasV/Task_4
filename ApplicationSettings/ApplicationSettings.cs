namespace ApplicationSettings
{
    public class ApplicationSettings
    {
        private string _programName;
        private string _programVersion;
        private DatabaseSettings dbSettings;

        public ApplicationSettings()
        {
            _programName = "Program Name";
            _programVersion = "v2.0";
            dbSettings = new DatabaseSettings("connection string");
        }

        public class DatabaseSettings
        {
            internal string _dbConnection;
            private TimeOnly _timeout;
            public DatabaseSettings(string connection)
            {
                _dbConnection = connection;
                _timeout = new TimeOnly(5000);
            }
        }

        public string ShowInfo()
        {
            return _programName + "\t" + _programVersion + "\n" + dbSettings._dbConnection;
        }
    }
}