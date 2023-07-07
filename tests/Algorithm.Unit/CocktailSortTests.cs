using Core.Algorithm;

namespace tests;

[TestClass]
public class CocktailSortTests
{
    [TestMethod]
    public void SortTest()
    {
        var list = new List<int>();

        var rnd = new Random();
        for(int i = 0; i < 8000; i++) {
            list.Add(rnd.Next(0, 1000));
        }

        var cocktailSort = new CocktailSort<int>(list);
        var listSort = new List<int>(list);

        cocktailSort.Sort();
        listSort.Sort();

        for(int i = 0; i < list.Count; i++) {
            Assert.AreEqual(listSort[i], cocktailSort.Items[i]);
        }
    }
}