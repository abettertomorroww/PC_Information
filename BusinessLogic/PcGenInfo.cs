using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace BusinessLogic
{
    public class PcGenInfo
    {
        /// <summary>
        /// Имя коипьютера
        /// </summary>
        /// <returns></returns>
        public static String GetComputerName()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                info = (string)mo["Name"];
                //mo.Properties["Name"].Value.ToString();
                //break;
            }
            return info;
        }

        /// <summary>
        /// Имя аккаунта
        /// </summary>
        /// <returns></returns>
        public static string GetAccountName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Name").ToString();
                }
                catch { }
            }
            return "User Account Name: Unknown";
        }



        /// <summary>
        /// Название клавиатуры 
        /// </summary>
        /// <returns></returns>
        public static string GetKeyboardName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Keyboard");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Name").ToString();
                }
                catch { }
            }
            return "Keyboard Name: Unknown";
        }

        /// <summary>
        /// Описание клавиатуры 
        /// </summary>
        /// <returns></returns>
        public static string GetKeyboardDescription()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Keyboard");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Description").ToString();
                }
                catch { }
            }
            return "Keyboard Description: Unknown";
        }

        /// <summary>
        /// MAC адресс
        /// </summary>
        /// <returns></returns>
        public static string GetMACAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            string MACAddress = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                if (MACAddress == String.Empty)
                {
                    if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
                }
                mo.Dispose();
            }
            MACAddress = MACAddress.Replace(":", "");
            return MACAddress;
        }
    }
}
