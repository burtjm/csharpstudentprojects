using System;
using System.Collections.Generic;
namespace StdDev
{
internal class Program
{
private static void Main()
{
int N = 10; /* list size */
List dlist = new List();
Random r = new Random(1);
for (int i = 1; i <= N; i++)
{
dlist.Add(r.Next());
};
 mean = dlist.Mean();
 var = dlist.Variance();
 sd = dlist.StandardDeviation();
Console.WriteLine("\nDate: " + DateTime.Now + "\n\n Random # List:\n");
foreach ( double d in dlist) Console.WriteLine (d);
Console.WriteLine("\nMean:\t {0} \nVar:\t {1} \nStdDev:\t {2}\n", mean, var, sd);
Console.ReadLine();
}
}
public static class methods
{
public static  Mean(this List values)
{
return values.Count == 0 ? 0 : values.Mean(0, values.Count);
}
public static  Mean(this List values, int start, int end)
{
 sum = 0;
for (int i = start; i < end; i++)
{
sum += values[i];
}
return sum / (end - start);
}
public static  Variance (this List values)
{
return values.Variance (values.Mean(), 0, values.Count);
}
public static double Variance (this List <double> values, double mean)
{
return values.Variance (mean(), 0, values.Count);

}
public static double Variance(this List<double> values, double mean, int start, int end)
{
 variance = 0;
for (int i = start; i < end; i++)
{
 variance += Math.Pow((values[i] - mean), 2);
}
int n = end - start;
if (start > 0) n -= 1;
return variance / (n);
}
public static  StandardDeviation(this List values)
{
return values.Count == 0 ? 0 : values.StandardDeviation(0, values.Count);
}
public static  StandardDeviation(this List values, int start, int end)
{
 mean = values.Mean(start, end);
 var = values.Variance(mean, start, end);
 std = Math.Sqrt(var);
return std;
}
}
}