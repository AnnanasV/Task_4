namespace ApplicationSettings
{
    public class ApplicationSettings
    {
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