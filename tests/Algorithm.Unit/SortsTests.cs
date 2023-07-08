using Core.Algorithm;

namespace Algoritm.Unit;

[TestClass]
public class SortsTests
{
    private List<int> _list = null!;
    private const int AmountOfNumbers = 10000;
    private const int From = 0;
    private const int To = 10000;

    [TestInitialize]
    public void Initialize() {
        _list = new List<int>();

        var rnd = new Random();
        for(int i = 0; i < AmountOfNumbers; i++) {
            _list.Add(rnd.Next(From, To));
        }

    }

    [TestMethod]
    public void BubbleSortTest()
    {
        var bubbleSort = new BubbleSort<int>(_list);
        var listSort = new List<int>(_list);

        var time = bubbleSort.SortAndGetTime();
        Console.WriteLine("Time of bubble sort: " + time);
        listSort.Sort();

        for(int i = 0; i < _list.Count; i++) {
            Assert.AreEqual(listSort[i], bubbleSort.Items[i]);
        }
    }

    [TestMethod]
    public void CocktailSortTest()
    {
        var cocktailSort = new CocktailSort<int>(_list);
        var listSort = new List<int>(_list);

        var time = cocktailSort.SortAndGetTime();
        Console.WriteLine("Time of cocktail sort: " + time);
        listSort.Sort();

        for(int i = 0; i < _list.Count; i++) {
            Assert.AreEqual(listSort[i], cocktailSort.Items[i]);
        }
    }

    [TestMethod]
    public void InsertSortTest()
    {
        var insertSort = new InsertSort<int>(_list);
        var listSort = new List<int>(_list);

        var time = insertSort.SortAndGetTime();
        Console.WriteLine("Time of insert sort: " + time);
        listSort.Sort();

        for(int i = 0; i < _list.Count; i++) {
            Assert.AreEqual(listSort[i], insertSort.Items[i]);
        }
    }

    [TestMethod]
    public void ShellSortTest()
    {
        var shellSort = new ShellSort<int>(_list);
        var listSort = new List<int>(_list);

        var time = shellSort.SortAndGetTime();
        Console.WriteLine("Time of shell sort: " + time);
        listSort.Sort();

        for(int i = 0; i < _list.Count; i++) {
            Assert.AreEqual(listSort[i], shellSort.Items[i]);
        }
    }
}