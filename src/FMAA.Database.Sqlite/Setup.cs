using System.Data.SQLite;
using System.Diagnostics;

namespace FMAA.Database.Sqlite
{
    public class Setup
    {
        public static void Main(string[] args)
        {
            string cmdText = "/C sqlite3 myTest.db < create.sql";
            Process.Start("cmd.exe", cmdText);
        }
    }
}
