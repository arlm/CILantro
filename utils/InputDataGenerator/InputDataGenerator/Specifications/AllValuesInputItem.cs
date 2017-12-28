using InputDataGenerator.Helpers;
using System.Collections.Generic;

namespace InputDataGenerator.Specifications
{
    public class AllValuesInputItem<T> : InputItemSpec
    {
        private readonly IEnumerator<T> _valuesEnumerator;

        private bool _isEnumerationFinished;

        public AllValuesInputItem()
        {
            if (typeof(T) == typeof(bool)) _valuesEnumerator = (IEnumerator<T>)BoolHelper.GetAllValues().GetEnumerator();
            _valuesEnumerator.Reset();

            _isEnumerationFinished = false;
        }


        public override object NextValue()
        {
            if (_isEnumerationFinished) return null;

            if (!_valuesEnumerator.MoveNext())
            {
                _isEnumerationFinished = true;
                return null;
            }

            var result = _valuesEnumerator.Current;

            return result;
        }

        public override void Reset()
        {
            _valuesEnumerator.Reset();
            _isEnumerationFinished = false;
        }
    }
}