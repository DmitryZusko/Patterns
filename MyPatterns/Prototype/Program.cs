namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var complicatedClass = new ClassWithComplicatedFields { ComplacatedField = 1, MoreComplicatedField = 2, FuckMyAssSoComplicatedField = 5 };
            var complicatedClone = complicatedClass.Clone();
            Console.WriteLine($"Origin: {complicatedClass}");
            Console.WriteLine($"clone: {complicatedClone}");

            var changeableComplicatedClass = new ComplicatedClassWithSimpleChanges();
            var changableableClone = changeableComplicatedClass.Clone();
            Console.WriteLine($"\n\nOrigin: {changeableComplicatedClass}");
            Console.WriteLine($"Clone {changableableClone}");
        }
    }
}