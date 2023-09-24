using System;
namespace Learn_Extension_Methods
{
    public static class IEnumerableExtensions
    {
        public static double Average(this IEnumerable<int> source)
        {
            if(source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            return (double) source.Sum() / source.Count();
        }
    }
}