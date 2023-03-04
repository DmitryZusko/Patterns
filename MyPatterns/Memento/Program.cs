namespace Memento
{
    /// <summary>
    /// Memento pattern is designed to save a state of object at the desired time. The main idea is to have 
    /// an object instance that will create a Memento instance and save there all fileds. CareTaker class 
    /// should store all mementoes, maybe provide some info about tham and initiate restoring process.
    /// If object class do not have any private fields to be stored, logic becomes a little bit less 
    /// complicated. 
    /// This pattern can be useful when we're dealing with Undo functionality.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var importantClass = new VeryImportantClass { PublicField = 0 };
            var careTaker = new CareTaker { ImportantClass = importantClass };
            careTaker.BackUp();

            Thread.Sleep(1000);

            importantClass.PublicField = 1;
            careTaker.BackUp();

            Thread.Sleep(1000);

            importantClass.PublicField = 2;
            careTaker.BackUp();

            careTaker.ShowHistory();

            importantClass.PublicField = 3;
            Console.WriteLine(importantClass.PublicField);

            careTaker.RestoreLast();

            Console.WriteLine(importantClass.PublicField);

            careTaker.ShowHistory();
        }
    }
}