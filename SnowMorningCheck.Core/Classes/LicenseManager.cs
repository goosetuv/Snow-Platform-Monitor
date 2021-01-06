using System.Data;

namespace SnowPlatformMonitor.Core.Classes
{
    public class LicenseManager
    {
        public DataTable ReportedYesterday()
        {
            SqlRunner sqlRunner = new SqlRunner();

            return sqlRunner.RunSQLDataTable("LicenseManagerReportedToday");
        }

        public DataTable Office365Import()
        {
            SqlRunner sqlRunner = new SqlRunner();
            return sqlRunner.RunSQLDataTable("Office365Import");
        }

        public DataTable AdobeImport()
        {
            SqlRunner sqlRunner = new SqlRunner();
            return sqlRunner.RunSQLDataTable("AdobeImport");
        }

        public string SRSImportDate()
        {
            SqlRunner sqlRunner = new SqlRunner();
            return sqlRunner.RunSQLString("SRSUpdateDate");
        }

    }
}
