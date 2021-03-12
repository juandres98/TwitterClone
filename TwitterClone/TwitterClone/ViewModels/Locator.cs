using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TwitterClone.Data;

namespace TwitterClone.ViewModels
{
    public static class Locator
    {
        private static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    string dbFilename = "TwitterLocalDB.db3";
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbFilename));
                }
                return database;
            }
        }
    }
}
