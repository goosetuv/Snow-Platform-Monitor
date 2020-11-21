using System;
using Laim;

namespace SnowMorningCheck.Core
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
    }
}
