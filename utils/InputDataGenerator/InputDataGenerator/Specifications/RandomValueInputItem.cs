using System;

namespace InputDataGenerator.Specifications
{
    public class RandomValueInputItem<T> : InputItemSpec
    {
        private readonly int _maxValues;

        private int _valueCounter;

        public RandomValueInputItem(int maxValues)
        {
            _maxValues = maxValues;

            _valueCounter = 0;
        }

        public override object NextValue()
        {
            throw new NotImplementedException();
        }

        public override void Reset()
        {
            throw new NotImplementedException();
        }
    }
}