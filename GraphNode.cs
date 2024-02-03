namespace graph;

public class GraphNode(string name)
{
    private readonly string _name = name;

    private readonly List<GraphNode> _children = [];

    private bool _visited;

    public string GetName()
    {
        return _name;
    }

    public void AddChildren(GraphNode graphNode)
    {
        if (ReferenceEquals(this, graphNode))
        {
            throw new ArgumentException("Cannot assign node as it's child!");
        }
        
        if (_children.Contains(graphNode))
        {
            throw new ArgumentException("Node already has this children!");
        }
        
        _children.Add(graphNode);
    }

    public List<GraphNode> GetChildren()
    {
        return _children.ToList();
    }

    public bool IsVisited()
    {
        return _visited;
    }

    public void MarkAsVisited()
    {
        if (_visited)
        {
            throw new ApplicationException("Node already visited!");
        }

        Console.WriteLine($"{_name} visited.");
        
        _visited = true;
    }

    public override bool Equals(object? obj)
    {
        if (
            ReferenceEquals(null, obj)
            || obj.GetType() != GetType()
        ) {
            return false;
        }
        
        return _name == ((GraphNode)obj)._name;
    }
}