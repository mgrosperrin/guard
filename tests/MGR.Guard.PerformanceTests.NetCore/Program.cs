using BenchmarkDotNet.Running;

namespace MGR.Guard.PerformanceTests.NetCore
{
    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<DirectVsSimpleExpression>();
        }
    }
}
