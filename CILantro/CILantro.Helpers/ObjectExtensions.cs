using System;

namespace CILantro.Helpers
{
    public static class ObjectExtensions
    {
        public static bool EqualsWithoutTypeChecking(this object object1, object object2)
        {
            if (object1.Equals(object2))
                return true;

            try
            {
                var newObject1 = Convert.ChangeType(object1, object2.GetType());
                if (newObject1.Equals(object2))
                    return true;
            }
            catch (Exception) { }

            try
            {
                var newObject2 = Convert.ChangeType(object2, object1.GetType());
                if (object1.Equals(newObject2))
                    return true;
            }
            catch (Exception) { }

            return false;
        }
    }
}