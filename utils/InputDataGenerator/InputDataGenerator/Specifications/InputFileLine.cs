using System.Collections.Generic;

namespace InputDataGenerator.Specifications
{
    public class InputFileLine
    {
        public IEnumerable<object> Items { get; set; }

        public InputFileLine(object item)
        {
            Items = new List<object>
            {
                item
            };
        }
    }
}