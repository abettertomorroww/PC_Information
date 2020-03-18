using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace BusinessLogic
{
    public class Disks
    {
        /// <summary>
        /// номер серии HDD.
        /// </summary>
        /// <returns></returns>
        public static String GetHDDSerialNo()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return result;
        }

        /// <summary>
        /// Размер блока диска
        /// </summary>
        /// <returns></returns>
        public static String GetDriveBlockSize()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["BlockSize"]);
            }
            return result;
        }

        /// <summary>
        /// Размер диска
        /// </summary>
        /// <returns></returns>
        public static String GetDriveSize()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["BlockSize"]);
            }
            return result;
        }

        /// <summary>
        /// Имя диска
        /// </summary>
        /// <returns></returns>
        public static string GetDriveName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Win32_LogicalDisk");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Name").ToString();
                }
                catch { }
            }
            return "Drive Name: Unknown";
        }

        /// <summary>
        /// Драйвера CDRom
        /// </summary>
        /// <returns></returns>
        public static string GetCdRomDrive()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CDROMDrive");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Drive").ToString();
                }
                catch { }
            }
            return "CD ROM Drive Letter: Unknown";
        }
    }
}
