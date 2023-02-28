using Builder.Builders;

namespace Builder
{
    public class Director
    {
        private IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public House BuildMainHouse()
        {
            return _builder
                .BuildFloor()
                .BuildWalls()
                .BuildRoof()
                .RetrieveHouse();
        }

        public House BuildHouseWithGarage()
        {
            return _builder
                .BuildFloor()
                .BuildWalls()
                .BuildRoof()
                .BuildGarage()
                .RetrieveHouse();
        }

        public House BuildHouseWithGarden()
        {
            return _builder
                .BuildFloor()
                .BuildWalls()
                .BuildRoof()
                .BuildGarden()
                .RetrieveHouse();
        }

        public House BuildFullPackageHouse()
        {
            return _builder
                .BuildFloor()
                .BuildWalls()
                .BuildRoof()
                .BuildGarage()
                .BuildGarden()
                .RetrieveHouse();
        }
    }
}