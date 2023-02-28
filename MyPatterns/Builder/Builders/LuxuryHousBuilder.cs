using Builder.BuildingElements;

namespace Builder.Builders
{
    public class LuxuryHousBuilder : IBuilder
    {
        private House _house;

        public LuxuryHousBuilder()
        {
            _house = Reset();
        }
        public IBuilder BuildFloor()
        {
            _house.Floor = new StoneFloor();
            return this;
        }

        public IBuilder BuildGarage()
        {
            _house.Garage = new BigGarage();
            return this;
        }

        public IBuilder BuildGarden()
        {
            _house.Garden = new BeautifulGarden();
            return this;
        }

        public IBuilder BuildRoof()
        {
            _house.Roof = new StoneRoof();
            return this;
        }

        public IBuilder BuildWalls()
        {
            _house.Walls = new StoneWall();
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
