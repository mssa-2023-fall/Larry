//Print all positive integer solutions to the equation a^3 + b^3 = c^3 + d^3
//Where (a,b,c,d) are integers between 1 and 1000


//BruteForce Solution:
using System.Xml.XPath;

int n = 0;
double a = Math.Pow(1,3);
double b = Math.Pow(2,3);
double c = Math.Pow(3,3);
double d = Math.Pow(4,3);

for(int i = 0; i < 1000; i++)
{
    if(a + b == c + d)
    {
        Console.WriteLine($"{a},{b},{c},{d}");
        break;
    }
}