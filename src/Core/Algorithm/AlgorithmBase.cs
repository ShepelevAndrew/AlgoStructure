using System.Diagnostics;

namespace Core.Algorithm;

public class AlgorithmBase<T> where T: IComparable, IComparable<T>
{
    public IList<T> Items { get; set; }

    public AlgorithmBase(IList<T> items)
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
        // TODO: quick sort as base
    }

    protected void Swop(int posA, int posB) {
        if(posA < Items.Count && posB < Items.Count) {
            var temp = Items[posA];
            Items[posA] = Items[posB];
            Items[posB] = temp;
        }
    }
}