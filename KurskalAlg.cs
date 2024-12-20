using System;
using System.Collections.Generic;

class Edge : IComparable<Edge>
{
    public int Source { get; }
    public int Destination { get; }
    public int Weight { get; }

    public Edge(int source, int destination, int weight)
    {
        Source = source;
        Destination = destination;
        Weight = weight;
    }

    public int CompareTo(Edge other)
    {
        return Weight.CompareTo(other.Weight);
    }
}

class UnionFind
{
    private int[] Parent;
    private int[] Rank;

    public UnionFind(int size)
    {
        Parent = new int[size];
        Rank = new int[size];

        for (int i = 0; i < size; i++)
        {
            Parent[i] = i;
            Rank[i] = 0;
        }
    }

    public int Find(int u)
    {
        if (Parent[u] != u)
            Parent[u] = Find(Parent[u]);

        return Parent[u];
    }

    public void Union(int u, int v)
    {
        int rootU = Find(u);
        int rootV = Find(v);

        if (rootU != rootV)
        {
            if (Rank[rootU] > Rank[rootV])
                Parent[rootV] = rootU;
            else if (Rank[rootU] < Rank[rootV])
                Parent[rootU] = rootV;
            else
            {
                Parent[rootV] = rootU;
                Rank[rootU]++;
            }
        }
    }
}

class KruskalAlgorithm
{
    public static List<Edge> KruskalMST(int vertices, List<Edge> edges)
    {
        edges.Sort();
        var uf = new UnionFind(vertices);
        var mst = new List<Edge>();

        foreach (var edge in edges)
        {
            if (uf.Find(edge.Source) != uf.Find(edge.Destination))
            {
                mst.Add(edge);
                uf.Union(edge.Source, edge.Destination);
            }
        }

        return mst;
    }

    public static void Main()
    {
        int vertices = 4;
        var edges = new List<Edge>
        {
            new Edge(0, 1, 10),
            new Edge(0, 2, 6),
            new Edge(0, 3, 5),
            new Edge(1, 3, 15),
            new Edge(2, 3, 4)
        };

        var mst = KruskalMST(vertices, edges);

        Console.WriteLine("Edges in the MST:");
        foreach (var edge in mst)
        {
            Console.WriteLine($"({edge.Source}, {edge.Destination}) - Weight: {edge.Weight}");
        }
    }
}
