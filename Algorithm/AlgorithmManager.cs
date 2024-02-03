using System.Diagnostics;
using graph.Algorithm.Implementation;

namespace graph.Algorithm;

public class AlgorithmManager
{
    private readonly Dictionary<AlgorithmType, IImplementation> _algorithms = new();
    
    public AlgorithmManager()
    {
        _algorithms.Add(AlgorithmType.DepthFirstSearch, new DepthFirstSearch());
        _algorithms.Add(AlgorithmType.BreadthFirstSearch, new BreadthFirstSearch());
    }
    
    public long GetTimeComplexity(AlgorithmType algorithmType, Graph graph)
    {
        if (!_algorithms.TryGetValue(algorithmType, out var implementation))
        {
            throw new Exception("Algorithm doesn't have implementation!");
        }
        
        var watch = Stopwatch.StartNew();
        implementation.Execute(graph.GetFirstGraphNode());
        watch.Stop();

        return watch.ElapsedMilliseconds;
    }
}