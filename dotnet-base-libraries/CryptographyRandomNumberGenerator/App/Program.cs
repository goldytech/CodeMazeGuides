using App;
using BenchmarkDotNet.Running;

Console.WriteLine(Convert.ToBase64String(CryptographicHelpers.GenerateRandomKey(32)));
Console.WriteLine(CryptographicHelpers.GenerateRandomInteger(1, 100));
BenchmarkRunner.Run<RandomNumberBenchmarks>();