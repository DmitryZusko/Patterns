namespace Prototype
{
    public class ClassWithComplicatedFields : IPrototype
    {
        public int ComplacatedField { get; set; }
        public int MoreComplicatedField { get; set; }
        public int FuckMyAssSoComplicatedField { get; set; }
        public IPrototype Clone()
        {
            return new ClassWithComplicatedFields
            {
                ComplacatedField = this.ComplacatedField,
                MoreComplicatedField = this.MoreComplicatedField,
                FuckMyAssSoComplicatedField = this.FuckMyAssSoComplicatedField
            };
        }

        public override string ToString()
        {
            return $"{ComplacatedField}, {MoreComplicatedField}, {FuckMyAssSoComplicatedField}";
        }
    }
}