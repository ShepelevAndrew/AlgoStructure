namespace Core.Algorithm;

public class SelectionSort<T> : AlgorithmBase<T>
    where T: IComparable, IComparable<T>
{
    public SelectionSort(IList<T> list) : base(list) { }

    public override void Sort()
    {
        int minIndex;

        for(int i = 0; i < Items.Count - 1; i++) {
            minIndex = i;

            for(int j = i + 1; j < Items.Count; j++) {
                if(Items[j].CompareTo(Items[minIndex]) == -1) {
                    minIndex = j;
                }
            }

            if(i != minIndex)
                Swop(i, minIndex);
        }
    }
}