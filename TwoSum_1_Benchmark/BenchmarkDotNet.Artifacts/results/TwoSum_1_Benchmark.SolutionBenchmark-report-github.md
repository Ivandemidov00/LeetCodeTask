``` ini

BenchmarkDotNet=v0.13.2, OS=manjaro 
Intel Core i5-2410M CPU 2.30GHz (Sandy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.108
  [Host]     : .NET 6.0.8 (6.0.822.41101), X64 RyuJIT AVX
  DefaultJob : .NET 6.0.8 (6.0.822.41101), X64 RyuJIT AVX


```

| Method    | nums         | target  |         Mean |        Error |       StdDev |       Gen0 | Allocated |
|-----------|--------------|---------|-------------:|-------------:|-------------:|-----------:|----------:|
| **Bench** | **Int32[4]** | **-15** | **19.08 ns** | **0.313 ns** | **0.418 ns** | **0.0204** |  **32 B** |
| **Bench** | **Int32[3]** | **6**   | **23.34 ns** | **0.318 ns** | **0.265 ns** | **0.0204** |  **32 B** |
| **Bench** | **Int32[4]** | **9**   | **18.52 ns** | **0.235 ns** | **0.208 ns** | **0.0204** |  **32 B** |
