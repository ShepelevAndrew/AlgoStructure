using Core.Algorithm;

namespace Algoritm.Unit;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void SortTest()
    {
        var list = new List<int>();

        var rnd = new Random();
        for(int i = 0; i < 8000; i++) {
            list.Add(rnd.Next(0, 1000));
        }

        var bubbleSort = new BubbleSort<int>(list);
        var listSort = new List<int>(list);

        bubbleSort.Sort();
        listSort.Sort();

        for(int i = 0; i < list.Count; i++) {
            Assert.AreEqual(listSort[i], bubbleSort.Items[i]);
        }
    }
}