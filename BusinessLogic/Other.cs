using System;
using System.Collections.Generic;
using System.Management;
using System.Text;


namespace BusinessLogic
{
    public class Other
    {

        /// <summary>
        /// Материнская плата
        /// </summary>
        /// <returns></returns>
        public static string GetBoardMaker()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Manufacturer").ToString();
                }
                catch { }
            }
            return "Board Maker: Unknown";
        }

        /// <summary>
        /// Id Мат.платы
        /// </summary>
        /// <returns></returns>
        public static string GetBoardProductId()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Product").ToString();
                }
                catch { }
            }
            return "Product: Unknown";
        }

      


        /// <summary>
        /// Производитель BIOS.
        /// </summary>
        /// <returns></returns>
        public static string GetBIOSmaker()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Manufacturer").ToString();
                }
                catch { }
            }
            return "BIOS Maker: Unknown";
        }


        /// <summary>
        /// Номер серии BIOS.
        /// </summary>
        /// <returns></returns>
        public static string GetBIOSserNo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("SerialNumber").ToString();

                }
                catch { }
            }
            return "BIOS Serial Number: Unknown";
        }


        /// <summary>
        /// Подпись BIOS.
        /// </summary>
        /// <returns></returns>
        public static string GetBIOScaption()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Caption").ToString();

                }
                catch { }
            }
            return "BIOS Caption: Unknown";
        }

      

       
    }
}
