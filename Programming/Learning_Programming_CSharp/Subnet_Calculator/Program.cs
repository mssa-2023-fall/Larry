using System;
using System.Data.Common;
using System.Net;
using System.Text;
namespace Subnetting
{
    class Program
    {
        static void Main(string[] args)
        {
            string binarySubnetMask;
            Console.WriteLine("\nPlease enter a binary subnet mask: \t\t\t\t\t Example: 11111111.11111111.11111111.11110000");
            binarySubnetMask = Console.ReadLine();
            TheCalculator calculator = new TheCalculator();

            Console.WriteLine($"\nYou entered: {binarySubnetMask}\nThe requested conversion from binary to an IP Address is: {calculator.BinaryCalculation(binarySubnetMask)}\n");

            string requestedNetworkID;
            string requestedSubnetMask;
            Console.WriteLine("Please enter a NetworkID in a 32-bit numerical label:\n ");
            requestedNetworkID = Console.ReadLine();
            Console.WriteLine("Next, enter a subnet mask:   \t\t\t\t\t\t Example: 255.255.255.0");
            requestedSubnetMask = Console.ReadLine();
            Console.WriteLine("\nConverted from string to an IP address:\n");
            calculator.NetworkAddressCalculation(requestedNetworkID,requestedSubnetMask);

            //  Easy Way. Add System.Net namespace
            //  IPAddress requestedIP = IPAddress.Parse("123.123.123.123");
            //  IPAddress requestedSubnet = IPAddress.Parse("23");
            //   Console.WriteLine($"\nThis is the requested IP: {requestedIP}!\n");

        }
    }
}



/*C# Subnet Calculator
given a tcpip address in the following format:
123.123.123.123/23


Task 1:
Parse the following Subnet address: --
11111111.11111111.11111110.00000000 --
Network ID:
123.123.122.0
Network range:
123.123.122.0 - 123.123.123.255

 
Task 2:
given a tcpip address in the following format:
123.123.123.123/23
determine if another IP address is in the same network.


bool IsSameNetwork(IPAddress)

 
Class IPAddress
byte[4] address
byte[4] subnetmask
byte[4] broadcast
byte[4] networkid
ctor 123.123.123.123/23
bool IsSameNetwork(IPAddress)
ToString=>123.123.123.123/23
*/