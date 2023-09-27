using System;
using System.Net;

class Program
{
    static void Main()
    {
        string binarySubnetMask = "11111111.11111111.11111110.00000000";

        // Split the binary subnet mask into octets
        string[] octets = binarySubnetMask.Split('.');

        if (octets.Length != 4)
        {
            Console.WriteLine("Invalid binary subnet mask format.");
            return;
        }

        try
        {
            // Convert each binary octet to decimal
            byte[] subnetMaskBytes = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                subnetMaskBytes[i] = Convert.ToByte(octets[i], 2);
            }

            // Create an IPAddress object from the subnet mask bytes
            IPAddress subnetMask = new IPAddress(subnetMaskBytes);

            // Define the IP address for the network ID
            IPAddress ipAddress = IPAddress.Parse("123.123.122.0");

            // Calculate the network ID
            byte[] ipAddressBytes = ipAddress.GetAddressBytes();
            byte[] networkIdBytes = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                networkIdBytes[i] = (byte)(ipAddressBytes[i] & subnetMaskBytes[i]);
            }

            IPAddress networkId = new IPAddress(networkIdBytes);

            // Calculate the network range
            byte[] broadcastAddressBytes = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                broadcastAddressBytes[i] = (byte)(networkIdBytes[i] | (byte)~subnetMaskBytes[i]);
            }
            IPAddress broadcastAddress = new IPAddress(broadcastAddressBytes);

            Console.WriteLine("Binary Subnet Mask: " + binarySubnetMask);
            Console.WriteLine("Network ID: " + networkId.ToString());
            Console.WriteLine("Network Range: " + networkId.ToString() + " - " + broadcastAddress.ToString());
            Console.WriteLine("Subnetmask is: " + subnetMask.ToString());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid binary subnet mask format.");
        }
    }
}
