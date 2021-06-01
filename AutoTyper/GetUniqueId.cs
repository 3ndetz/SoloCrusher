using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AutoTyper
{
    public static class GetUniqueId
    {
        public static bool CheckIdActivation(string id)
        {
            bool activated = false;
            foreach (string AllowedId in AllowedIds)
            {
                if (AllowedId == id) { activated = true; break; }
            }
            if (activated) return true; else return false;
        }
        public static List<string> AllowedIds { get; set; } = new List<string>
        {
            "daun",
            "privet",
            "fdsgf",
            "F3-D9-54-2C-0A-2D-3B-5E-78-89-2B-58-C0-B6-02-A4-7D-16-8F-BC-C6-C5-B4-97-6E-99-9B-57-9F-B0-06-25",
        };
        public static string UniqueHardwaeId
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                      "SELECT * FROM Win32_Processor");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    sb.Append(queryObj["NumberOfCores"]);
                    sb.Append(queryObj["ProcessorId"]);
                    sb.Append(queryObj["Name"]);
                    sb.Append(queryObj["SocketDesignation"]);

                    Console.WriteLine(queryObj["ProcessorId"]);
                    Console.WriteLine(queryObj["Name"]);
                    Console.WriteLine(queryObj["SocketDesignation"]);
                }

                searcher = new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_BIOS");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    sb.Append(queryObj["Manufacturer"]);
                    sb.Append(queryObj["Name"]);
                    sb.Append(queryObj["Version"]);

                    Console.WriteLine(queryObj["Manufacturer"]);
                    Console.WriteLine(queryObj["Name"]);
                    Console.WriteLine(queryObj["Version"]);
                }

                searcher = new ManagementObjectSearcher("root\\CIMV2",
                       "SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    sb.Append(queryObj["Product"]);
                    Console.WriteLine(queryObj["Product"]);
                }

                var bytes = Encoding.ASCII.GetBytes(sb.ToString());
                SHA256Managed sha = new SHA256Managed();

                byte[] hash = sha.ComputeHash(bytes);

                return BitConverter.ToString(hash);
            }
        }
    }
}
