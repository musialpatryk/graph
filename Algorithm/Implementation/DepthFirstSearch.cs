using graph.Algorithm.Implementation;

namespace project_2.Algorithm.Implementation;

public class BubbleSort : IImplementation
{
    public void Execute(int[] array)
    {
        for (var i = 0; i < array.Length - 1; i++)
        {
            for (var j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }
}