using System;

namespace InputDataGenerator.Specifications
{
    public abstract class InputItemSpec
    {
        private readonly Type _itemType;

        public InputItemSpec(Type itemType)
        {
            _itemType = itemType;
        }
    }
}