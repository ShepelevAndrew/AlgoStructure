using System.Diagnostics;

namespace Core.Algorithm;

public class AlgorithmBase<T> where T: IComparable<T>
{
    public List<T> Items { get; set; }

    public AlgorithmBase(List<T> items)
    {
        Items = items;
    }

    public TimeSpan SortAndGetTime() {
        var timer = new Stopwatch();

        timer.Start();
        Sort();
        timer.Stop();

        return timer.Elapsed;
    }

    public virtual void Sort() {
        Items.Sort();
    }

    protected void Swop(int posA, int posB) {
        if(posA < Items.Count && posB < Items.Count) {
            var temp = Items[posA];
            Items[posA] = Items[posB];
            Items[posB] = temp;
        }
    }
}