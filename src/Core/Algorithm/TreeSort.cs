using Core.DataStructure;

namespace Core.Algorithm;

public class TreeSort<T> : AlgorithmBase<T>
    where T: IComparable, IComparable<T>
{
    public TreeSort(IList<T> list) : base(list) { }

    public override void Sort()
    {
        var tree = new Tree<T>(Items);
        List<T> sorted = tree.Inorder();
        Items = sorted;
    }
}