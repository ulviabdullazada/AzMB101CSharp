using Core.Interfaces;

namespace Core.Models;

public class Plane : Vehicle, IEngine, ITransmission
{
    public bool TransmissionKind { get; set; }
    public uint HorsePower { get; set; }
    public float TankSize { get; set; }
    public float CurrentOil { get; set; }
    public byte FuelType { get; set; }
    public float RemainOilAmount()
       => TankSize - CurrentOil;
}
