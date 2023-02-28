namespace Prototype
{
    public class ComplicatedClassWithSimpleChanges : IPrototype
    {
        public int ComplicatedField { get; }
        public int MoreComplicatedField { get; }
        public int FieldToBeDividedByTwo { get; }

        public ComplicatedClassWithSimpleChanges()
        {
            ComplicatedField = 1;
            MoreComplicatedField = 2;
            FieldToBeDividedByTwo = 6;
        }

        protected ComplicatedClassWithSimpleChanges(ComplicatedClassWithSimpleChanges instance)
        {
            ComplicatedField = instance.ComplicatedField;
            MoreComplicatedField = instance.MoreComplicatedField;
            FieldToBeDividedByTwo = instance.FieldToBeDividedByTwo / 2;
        }
        public IPrototype Clone()
        {
            return new ComplicatedClassWithSimpleChanges(this);
        }

        public override string ToString()
        {
            return $"{ComplicatedField}, {MoreComplicatedField}, {FieldToBeDividedByTwo}";
        }
    }
}