using System.Data;
using System.ServiceProcess;

namespace SnowPlatformMonitor.Core.Classes
{
    public class WindowsServices
    {
        public DataTable GetServices(string hostname)
        {
            ServiceController[] services = ServiceController.GetServices(hostname);

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Status");

            foreach (ServiceController service in services)
            {
                if (service.DisplayName.ToLower().Contains("snow"))
                {
                    DataRow dr = dt.NewRow();
                    dr["Name"] = service.DisplayName;
                    dr["Status"] = service.Status;
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

    }
}
