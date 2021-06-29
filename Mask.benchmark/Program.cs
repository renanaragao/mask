using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Salazar.CSharp.String.Mask;

namespace Mask.benchmark
{

    public class Mask
    {
        private readonly string data;

        public Mask()
        {
            data = Enumerable.Range(1, 11).Aggregate("", (current, next) => $"{current}{next}");
        }

        [Benchmark]
        public string Salazar() => data.ToMask("(##) #####-####");

        [Benchmark]
        public string Masked() => data.ToMasked("(AA) AAAAA-AAAA");
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Mask>
            (
                DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
                .AddDiagnoser()
            );
        }
    }
}
