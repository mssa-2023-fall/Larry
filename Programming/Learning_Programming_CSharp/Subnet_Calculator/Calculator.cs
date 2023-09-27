using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace Subnetting
{
    public class TheCalculator
    {  // Parse the following Subnet address: 11111111.11111111.11111110.00000000
        private string binarySubnetMask { get; set; }
        private string NetworkID { get; set; }
        private string SubnetMaskID { get; set; }
     // public bool IsSameNetwork(string Network1, string Network2) { if (IPAddress network1 = IPAddress.Parse(Network1).Equals(IPAddress network2 = IPAddress.Parse(Network2)){return true;}};
        public string BinaryCalculation(string binarySubnetMask)
        {
            byte[] subnetMaskBytes = new byte[4];
            // Split the binary subnet mask into octets
            string[] decoupleBinarySubnetMask = binarySubnetMask.Split('.');
            for (int i = 0; i < 4; i++)
            {
                subnetMaskBytes[i] = Convert.ToByte(decoupleBinarySubnetMask[i], 2);
            }
            var results = new IPAddress(subnetMaskBytes);

            return results.ToString();
        }


        public void NetworkAddressCalculation(string NetworkID, string SubnetMaskID)
        {
            IPAddress networkId = IPAddress.Parse(NetworkID);
            IPAddress subnetMask = IPAddress.Parse(SubnetMaskID);

            Console.WriteLine(networkId.ToString());
            Console.WriteLine(subnetMask.ToString());
        }

       /* public IPAddress(string ipAddressWithSubnet)
        {
            //getting range:
            
            // Parse the input string to extract the address and subnet mask.
            string[] parts = ipAddressWithSubnet.Split('/');
            if (parts.Length != 2 || !IPAddress.TryParse(parts[0], out System.Net.IPAddress ipAddr) || !byte.TryParse(parts[1], out byte subnet))
            {
                throw new ArgumentException("Invalid IP address format");
            }

            this.address = ipAddr.GetAddressBytes();

            // Calculate the subnet mask based on the CIDR notation.
            this.subnetmask = new byte[4];
            for (int i = 0; i < subnet; i++)
            {
                this.subnetmask[i / 8] |= (byte)(1 << (7 - (i % 8)));
            }

            // Calculate the network ID.
            this.networkid = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                this.networkid[i] = (byte)(this.address[i] & this.subnetmask[i]);
            }
            
        }*/
    }
}