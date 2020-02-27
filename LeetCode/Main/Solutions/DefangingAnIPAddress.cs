using System;

namespace LeetCode.Main.Solutions
{
    public static class DefangingAnIPAddress
    {
        public static string DefangIPAddress(string address)
        {
            if (address.Contains("."))
            {
                address = address.Replace(".", "[.]");
            }
            Console.WriteLine(address);
            return address;
        }
    }
}