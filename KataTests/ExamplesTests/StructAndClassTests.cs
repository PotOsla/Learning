using Examples.StructsAndClasses;

namespace KataTests.ExamplesTests
{
    [TestFixture]
    internal class StructAndClassTests
    {
        [Test]
        public void TimeCheckStructs()
        {
            StructItem[] items = new StructItem[10000000];
            for (int i = 0; i < items.Length - 1; i++)
            {
                items[i] = new StructItem(i, i + 1, i + 2);
            }
            long sum = 0;
            for (int i = 0; i < items.Length - 1; i++)
            {
                sum += items[i].y + items[i].x + items[i].z;
            }
        }

        [Test]
        public void TimeCheckSClasses()
        {
            ClassItem[] items = new ClassItem[10000000];
            for (int i = 0; i < items.Length - 1; i++)
            {
                items[i] = new ClassItem(i, i + 1, i + 2);
            }
            long sum = 0;
            for (int i = 0; i < items.Length - 1; i++)
            {
                sum += items[i].y + items[i].x + items[i].z;
            }
        }
    }
}
