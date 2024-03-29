﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace MGR.Guard.PerformanceTests.NetCore
{
    [SimpleJob(RuntimeMoniker.Net80)]
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
            Guardian.ChecksThat.IsNotNull(obj, nameof(obj));
        }

        [Benchmark]
        public void SimpleExpression()
        {
            SimpleExpression(_obj);
        }

        private void SimpleExpression(object obj)
        {
            Guardian.ChecksThat.IsNotNull(() => obj);
        }
    }
}