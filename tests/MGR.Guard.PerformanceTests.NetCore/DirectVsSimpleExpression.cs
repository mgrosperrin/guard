using BenchmarkDotNet.Attributes;

namespace MGR.Guard.PerformanceTests.NetCore
{
    [CoreJob]
    public class DirectVsSimpleExpression
    {
        private readonly object _obj;

        public DirectVsSimpleExpression()
        {
            _obj = new object();
        }

        [Benchmark]
        public void Direct()
        {
            Direct(_obj);
        }

        private void Direct(object obj)
        {
            Guard.IsNotNull(obj, nameof(obj));
        }

        [Benchmark]
        public void SimpleExpression()
        {
            SimpleExpression(_obj);
        }

        private void SimpleExpression(object obj)
        {
            Guard.IsNotNull(() => obj);
        }
    }
}