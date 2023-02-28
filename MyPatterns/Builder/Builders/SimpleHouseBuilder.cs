using Builder.BuildingElements;

namespace Builder.Builders
{
    public class SimpleHouseBuilder : IBuilder
    {
        private House _house;
        public SimpleHouseBuilder()
        {
            _house = Reset();
        }
        public IBuilder BuildFloor()
        {
            _house.Floor = new WoodenFloor();
            return this;
        }

        public IBuilder BuildWalls()
        {
            _house.Walls = new WoodenWall();
            return this;
        }

        public IBuilder BuildRoof()
        {
            _house.Roof = new WoodenRoof();
            return this;
        }

        public IBuilder BuildGarage()
        {
            _house.Garage = new SmallGarage();
            return this;
        }

        public IBuilder BuildGarden()
        {
            _house.Garden = new SimpleGarden();
            return this;
        }

        public House RetrieveHouse()
        {
            var resultHouse = _house;
            _house = Reset();
            return resultHouse;
        }

        private House Reset()
        {
            return new House();
        }
    }
}