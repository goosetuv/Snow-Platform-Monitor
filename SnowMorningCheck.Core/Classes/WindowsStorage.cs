using System;
using System.Data;
using System.Management;

namespace SnowPlatformMonitor.Core.Classes
{
    public class WindowsStorage
    {
        public DataTable GetWindowStorage(string HostName, string win32Type, string username = "", string password = "", bool useCredentials = false)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Name");
            dt.Columns.Add("Size (GB)");
            dt.Columns.Add("Free Space (GB)");

            ManagementObjectSearcher query = null;
            ManagementObjectCollection queryCollection = null;

            ConnectionOptions opt = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Authentication = AuthenticationLevel.Packet,
                EnablePrivileges = true
            };

            if (useCredentials == true)
            {
                opt.Username = username;
                opt.Password = password;
            }

            ManagementPath mp = new ManagementPath
            {
                NamespacePath = @"\root\cimv2",
                Server = HostName
            };

            ManagementScope msc = new ManagementScope(mp, opt);

            SelectQuery q = new SelectQuery(win32Type); //Win32_Environment, Win32_Service etc

            query = new ManagementObjectSearcher(msc, q, null);
            queryCollection = query.Get();

            foreach (ManagementObject mo in queryCollection)
            {
                DataRow dr = dt.NewRow();
                dr["Name"] = mo["Name"];
                dr["Size (GB)"] = Convert.ToInt64(mo["Size"]) / 1024 / 1024 / 1024;
                dr["Free Space (GB)"] = Convert.ToInt64(mo["FreeSpace"]) / 1024 / 1024 / 1024;
                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
