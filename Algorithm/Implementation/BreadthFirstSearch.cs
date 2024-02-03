namespace graph.Algorithm.Implementation;

public class BreadthFirstSearch : IImplementation
{
    public void Execute(GraphNode startingNode)
    {
        LinkedList<GraphNode> queue = [];

        queue.AddLast(startingNode);
        startingNode.MarkAsVisited();

        while (queue.Count > 0) {
            var firstNode = queue.First();
            queue.RemoveFirst();
 
            foreach (var childNode in firstNode.GetChildren().Where(val => !val.IsVisited()))
            {
                childNode.MarkAsVisited();
                queue.AddLast(childNode);
            }
        }
    }
}