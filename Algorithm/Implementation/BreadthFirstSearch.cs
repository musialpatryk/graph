namespace graph.Algorithm.Implementation;

public class DepthFirstSearch : IImplementation
{
    public void Execute(GraphNode startingNode)
    {
        startingNode.MarkAsVisited();

        foreach (var childNode in startingNode.GetChildren().Where(childNode => !childNode.IsVisited()))
        {
            Execute(childNode);
        }
    }
}