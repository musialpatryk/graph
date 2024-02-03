using System.Data;

namespace graph;

public class Graph
{
    private readonly List<GraphNode> _graphNodes = [];

    public void AddNode(GraphNode graphNode)
    {
        if (_graphNodes.Contains(graphNode))
        {
            throw new ArgumentException("Graph node already present in graph!");
        }
        
        _graphNodes.Add(graphNode);
    }

    public GraphNode GetFirstGraphNode()
    {
        if (_graphNodes.Count == 0)
        {
            throw new DataException("Graph doesn't contain any nodes!");
        }
        
        return _graphNodes.First();
    }

    public List<GraphNode> GetGraphNodes()
    {
        return _graphNodes.ToList();
    }

    public bool ValidateGraphVisitation()
    {
        return _graphNodes.All(graphNode => graphNode.IsVisited());
    }
}