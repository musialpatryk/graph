namespace graph;

public class Graph(Dictionary<string, List<string>> edges)
{
    private readonly List<string> _visitedEdges = [];

    public void VisitEdge(string edge)
    {
        if (!edges.ContainsKey(edge))
        {
            throw new ArgumentOutOfRangeException(edge, "Edge doesn't exists.");
        }
        
        if (!_visitedEdges.Contains(edge))
        {
            throw new ArgumentException("Edge already visited.", edge);
        }
        
        _visitedEdges.Add(edge);
    }

    public bool AllEdgesVisited()
    {
        return _visitedEdges.Count == edges.Count;
    }
}