using AbstractFactory.Items;

namespace AbstractFactory.AbstractFactory
{
    /// <summary>
    /// Abstract factory is an agregation of factory methods into one class. If there're situations when we need to create a bunch of 
    /// objects and it's better to be undetermined (without hardcode) - abstract factory is our solution. Because client code use factories through 
    /// interface and factories use products through their interfaces, we can easily replace concrete factories with their concrete products when and 
    /// where we need it. And the best part - client don't care about all this logic!
    /// </summary>
    public interface IEquipmentFactory
    {
        public IWeapon CreateWeapon();

        public IShield CreateShield();

        public IArmor CreateArmor();
    }
}
