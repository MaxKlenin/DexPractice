using System.Collections;

namespace IEnumerableIEnumeratorLibrary
{
    public class Basket : IEnumerable
    {
        private Fruit[] _fruits;

        public Basket(Fruit[] fArray)
        {
            _fruits = new Fruit[fArray.Length];

            for (int i = 0; i < fArray.Length; i++)
            {
                _fruits[i] = fArray[i];
            }
        }

        public IEnumerator GetEnumerator() => new FruitEnumerator(_fruits);
    }
}