using InputDataGenerator.Extensions;
using System;

namespace InputDataGenerator.Specifications
{
    public class RandomValueInputItem<T> : InputItemSpec
    {
        private readonly int _maxValues;

        private int _valueCounter;
        private Random _random;

        public RandomValueInputItem(int maxValues)
        {
            _random = new Random();

            _maxValues = maxValues;

            _valueCounter = 0;
        }

        public override object NextValue()
        {
            if (_valueCounter == _maxValues) return null;
            _valueCounter++;
            return _random.NextOfType(typeof(T));
        }

        public override void Reset()
        {
            _random = new Random();
            _valueCounter = 0;
        }
    }
}