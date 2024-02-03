using graph.Algorithm;
using static System.Int32;

namespace graph.GraphIO;

public static class GraphIO
{
    public static AlgorithmType GetAlgorithm()
    {
        AlgorithmType? selectedAlgorithm = null;
        var algorithmValues = Enum.GetValues<AlgorithmType>();

        while (selectedAlgorithm == null)
        {
            Console.WriteLine("Select algorithm with it's value:");

            var counter = 1;
            foreach (var algorithmType in algorithmValues)
            {
                Console.WriteLine($"{counter++}. {algorithmType}");
            }

            var keyString = Console.ReadKey().KeyChar.ToString();
            if (!TryParse(keyString, out var keyNumber)) continue;
            try
            {
                selectedAlgorithm = algorithmValues.ElementAt(--keyNumber);
            } 
            catch (ArgumentOutOfRangeException) {}
        }

        Console.Clear();
        
        return (AlgorithmType)selectedAlgorithm;
    }

    public static Graph GetGraph()
    {
        Console.WriteLine("Type graph node names (separate with [enter], type \"stop\" after finish):");
        
        var input = string.Empty;
        var graph = new Graph();
        while (input != "stop")
        {
            input = Console.ReadLine();

            if (input is null or "stop")
            {
                continue;
            }

            var graphNode = new GraphNode(input);
            graph.AddNode(graphNode);
        }
        
        Console.Clear();

        return graph;
    }

    public static void AssignChildren(Graph graph)
    {
        foreach (var graphNode in graph.GetGraphNodes())
        {
            Console.Clear();
            Console.WriteLine($"Pass {graphNode.GetName()} children names (separate with [enter], type \"stop\" after finish):");
            
            var input = string.Empty;
            while (input != "stop")
            {
                input = Console.ReadLine();

                if (input is null or "stop")
                {
                    continue;
                }

                var childNode = graph.GetGraphNodes().Find((node) => node.GetName() == input);
                if (childNode == null)
                {
                    continue;
                }
                
                graphNode.AddChildren(childNode);
            }
        }
        
        Console.Clear();
    }
}