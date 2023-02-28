namespace Composite
{
    /// <summary>
    /// Let's imagine we have an object and a box that can contain the object. And than we create
    /// a bigger box, that can contain the object, the box with object or another box with box with 
    /// the object inside. So, if we want to call an object's method but we don't know if 
    /// we work with the object itself or the box with objects - the Composite pattern coming handy.
    /// The main idea is to create an aggregation class that will implement an <c>IObject</c>
    /// interface and has a container with objects or instances of the same class inside.
    /// The method inside this aggregation class should iterate throughout own collection
    /// and call a correspondible method in all items. If we again hit an aggregation class - 
    /// same work; if the object itself (leaf object in this tree) - it will «quack».
    /// </summary>
    public interface IDuck
    {
        void SayQuack();
    }
}