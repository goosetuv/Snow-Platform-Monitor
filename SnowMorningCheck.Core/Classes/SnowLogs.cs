using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace SnowPlatformMonitor.Core.Classes
{
    public class SnowLogs
    {
        readonly string[] SEARCH_TYPE = { " ERROR ", " ERR ", " FATAL ", " FTL " };

        internal static List<string> GetSubDirectories(string directory)
        {
            List<string> DirectoryList = new List<string>();

            foreach(string dir in Directory.GetDirectories(directory))
            {
                DirectoryList.Add(dir);
            }

            return DirectoryList;
        }

        internal static string GetNewestLog(string directory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            if (directoryInfo == null || !directoryInfo.Exists)
                return "";

            FileInfo[] files = directoryInfo.GetFiles();
            DateTime recentWrite = DateTime.MinValue;
            FileInfo recentFile = null;

            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > recentWrite)
                {
                    recentWrite = file.LastWriteTime;
                    recentFile = file;
                }
            }
            if(recentFile != null )
            {
                return recentFile.Name;
            } else
            {
                return "";
            }
        }

        public DataTable GetLogData(string directory)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("LogPath");
            dt.Columns.Add("LogName");
            dt.Columns.Add("Error");
            dt.Columns.Add("Fatal");

            foreach (string dir in GetSubDirectories(@"C:\Program Files\Snow Software\Logs\"))
            {
                if(dir.Contains("ImportTool") == false) 
                {
                    string latestFile = GetNewestLog(dir + @"\");

                    bool ERROR_PRESENT = false;
                    bool FATAL_PRESENT = false;

                    // use streamreader because the files might still be in used by their service
                    Stream stream = File.Open(dir + @"\" + latestFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    StreamReader streamReader = new StreamReader(stream);
                    string str = streamReader.ReadToEnd();
                    streamReader.Close();
                    stream.Close();

                    // Spaces are to account for false positives
                    // Might not be 100% so may need updated 
                    if (str.Contains(" ERROR ") || str.Contains(" ERR "))
                    {
                        ERROR_PRESENT = true;
                    }

                    if (str.Contains(" FATAL ") || str.Contains(" FTL "))
                    {
                        FATAL_PRESENT = true;
                    }

                    DataRow dr = dt.NewRow();
                    dr["LogPath"] = dir;
                    dr["LogName"] = latestFile;
                    dr["Error"] = ERROR_PRESENT;
                    dr["Fatal"] = FATAL_PRESENT;
                    dt.Rows.Add(dr);
                }
            }

            return dt;

        }
    }
}
