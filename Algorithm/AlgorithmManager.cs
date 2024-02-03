using System.Diagnostics;
using project_2.Algorithm.Implementation;

namespace project_2.Algorithm;

public class AlgorithmManager
{
    private readonly Dictionary<AlgorithmType, IImplementation> _algorithms = new();
    
    public AlgorithmManager()
    {
        _algorithms.Add(AlgorithmType.InsertionSort, new InsertionSort());
        _algorithms.Add(AlgorithmType.BubbleSort, new BubbleSort());
        _algorithms.Add(AlgorithmType.SelectionSort, new SelectionSort());
    }
    
    public long GetTimeComplexity(AlgorithmType algorithmType, int[] array)
    {
        if (!_algorithms.TryGetValue(algorithmType, out var implementation))
        {
            throw new Exception("Algorithm doesn't have implementation!");
        }
        
        var watch = Stopwatch.StartNew();
        implementation.Execute(array);
        watch.Stop();

        return watch.ElapsedMilliseconds;
    }
}