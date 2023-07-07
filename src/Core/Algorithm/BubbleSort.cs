namespace Core.Algorithm;

public class BubbleSort<T> : AlgorithmBase<T> where T: IComparable<T>
{
    public BubbleSort(List<T> list) : base(list) {}

    public override void Sort()
    {
        int count = Items.Count;

        for(int j = 0; j < count; j++) {
            for(int i = 0; i < count - 1 - j; i++) {
                var prev = Items[i];
                var current = Items[i + 1];

                if(prev.CompareTo(current) == 1)
                {
                    Swop(i, i + 1);
                }
            }
        }
    }    
}