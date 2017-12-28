namespace InputDataGenerator.Specifications
{
    public abstract class InputItemSpec
    {
        public abstract object NextValue();

        public abstract void Reset();
    }
}