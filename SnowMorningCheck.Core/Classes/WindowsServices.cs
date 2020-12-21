#region Dependencies
using System.Data;
using System.ServiceProcess;
#endregion

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
            dt.Columns.Add("Start Type");
            dt.Columns.Add("Service Depends On");

            foreach (ServiceController service in services)
            {
                if (service.DisplayName.ToLower().Contains("snow"))
                {
                    string serviceDepencyList = "";
                    foreach (var dep in service.ServicesDependedOn)
                    {
                        serviceDepencyList += dep.DisplayName + ",";
                    }

                    DataRow dr = dt.NewRow();
                    dr["Name"] = service.DisplayName;
                    dr["Status"] = service.Status;
                    dr["Start Type"] = service.StartType;
                    dr["Service Depends On"] = string.Join(",", serviceDepencyList.TrimEnd(','));
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

    }
}
