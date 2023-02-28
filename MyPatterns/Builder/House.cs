using Builder.BuildingElements;

namespace Builder
{
    public class House
    {
        public IFloor Floor { get; set; }
        public IWall Walls { get; set; }
        public IRoof Roof { get; set; }
        public IGarage Garage { get; set; }
        public IGarden Garden { get; set; }

        public override string ToString()
        {
            return $"Floor - {Floor}, Walls - {Walls},\n Roof - {Roof}, Garage - {Garage},\n Garden - {Garden}";
        }
    }
}