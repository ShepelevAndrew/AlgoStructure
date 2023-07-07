namespace Core.Algorithm;

public class AlgorithmBase<T>
{
    public List<T> Items { get; set; }

    public AlgorithmBase(List<T> items)
    {
        Items = items;
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