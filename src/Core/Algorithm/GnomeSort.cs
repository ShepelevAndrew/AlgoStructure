namespace Core.Algorithm;

public class GnomeSort<T> : AlgorithmBase<T> where T: IComparable, IComparable<T>
{
    public GnomeSort(IList<T> list) : base(list) { }

    public override void Sort()
    {
        int i = 1;
        while(i < Items.Count) {
            if(i == 0 || Items[i].CompareTo(Items[i - 1]) != -1) {
                i++;
            }
            else {
                Swop(i, i - 1);
                i--;
            }
        }   
    }
}