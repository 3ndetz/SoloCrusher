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
            "35-03-F1-26-3D-63-10-BE-39-00-30-3F-EC-8A-35-A7-27-8A-88-8D-BF-53-A3-7B-FD-4B-2F-8A-EE-2B-9F-9C",
            "A6-40-96-ED-AB-C3-F0-21-A4-C4-EF-A5-48-C4-3E-45-A4-BC-A1-CE-EF-65-7A-F2-3A-C0-D5-56-73-0C-28-E6",
            "51-76-4A-4A-59-24-F5-65-3F-17-B9-C5-8E-DB-9D-0B-54-B9-F4-C8-B2-E5-80-9E-70-BB-BB-40-7C-82-4D-4B",
            "D8-B1-50-FE-F8-E0-F5-1F-16-65-5E-81-31-91-62-61-DE-79-87-B5-D5-B7-16-C8-8F-C9-00-79-2C-71-8C-3C",
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
