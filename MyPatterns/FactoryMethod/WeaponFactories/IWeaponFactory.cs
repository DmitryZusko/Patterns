namespace FactoryMethod.WeaponFactories
{
    using FactoryMethod.Weapons;
    /// <summary>
    /// Factory patterns allows us withdraw creating logic from main class, so it will not violate SRP.
    /// The main ourpouse is to be able to create different products (IWeapons) at the runtime.
    /// If we have a bunch of classes that implement general interface, we don't know what exect class instance client will request and 
    /// we don't want to bother client with creating responsibility - factory method is a good choise. 
    /// also it's very easy to add new products. 
    /// </summary>
    public interface IWeaponFactory
    {
        IWeapon GetWeapon();
    }
}
