namespace Patterns.Builder
{
    public class TripLaptopBuilder : LaptopBuilder
    {
        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1200X800";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Core 2 Duo, 3.2 GHz";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "3000 Mb";
        }

        public override void SetHDD()
        {
            Laptop.HDD = "1000 Gb";
        }

        public override void SetBattery()
        {
            Laptop.Battery = "3 lb";
        }
    }
}