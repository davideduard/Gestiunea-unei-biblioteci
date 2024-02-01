class DbManagement
    {
        private static SqlConnection dbConn = null;

        private static void GetConnection()
        {
            dbConn = new SqlConnection(Properties.Settings.Default.dbConn);
        }

        public static SqlConnection DbConn
        {
            get 
            {
                if (dbConn == null)
                    GetConnection();
                return dbConn;
            }
        }