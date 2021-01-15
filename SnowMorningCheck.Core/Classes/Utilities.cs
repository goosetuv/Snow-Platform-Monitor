﻿#region Dependencies
using System;
using System.IO;
using System.Net.NetworkInformation;
using Laim;
#endregion

namespace SnowPlatformMonitor.Core.Classes
{
    public static class Utilities
    {
        // Encrypts a string using laim.utility
        public static string Encrypt(string value)
        {
            return Kryptos.Encrypt(value, Kryptos.GetHardwareID());
        }

        // Decrypts a string using laim.utility
        public static string Decrypt(string value)
        {
            return Kryptos.Decrypt(value, Kryptos.GetHardwareID());
        }

        // Read the specific node from a configuration file
        public static string ReadXMLValue(string path, string node)
        {
            return XmlConfigurator.Read(path, node);
        }

        // Date Format, that's all really
        public static string DateFormat(DateTime date, string format = "dd-MM-yyyy")
        {
            return date.ToString(format);
        }

        public static bool IsSqlCorrect(string sqlConnection)
        {
            return MSSqlServer.CheckConnnection(sqlConnection);
        }   

        public static bool PingHost(string hostName)
        {
            try
            {
                Ping p = new Ping();
                if (p.Send(hostName, 200).Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void LogRetention(string logDirectory, int retentionDays)
        {
            string[] files = Directory.GetFiles(logDirectory);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.LastAccessTime < DateTime.Now.AddDays(-retentionDays))
                {
                    fileInfo.Delete();
                }
            }
        }
    }
}
