using System;

namespace GetterOnlyAutoProperties
{
    class Car
    {
        public string LicensePlate { get; } = GetNewLicensePlate();

        private static string GetNewLicensePlate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
