using graph.Algorithm;
using graph.GraphIO;

var algorithmType = GraphIO.GetAlgorithm();
var graph = GraphIO.GetGraph();
GraphIO.AssignChildren(graph);

var algorithmManager = new AlgorithmManager();
var timeComplexity = algorithmManager.GetTimeComplexity(algorithmType, graph);
Console.WriteLine(timeComplexity);

Console.WriteLine("Validate => " + graph.ValidateGraphVisitation());

Console.ReadKey();  