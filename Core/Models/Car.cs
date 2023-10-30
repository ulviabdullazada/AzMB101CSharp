using Core.Interfaces;

namespace Core.Models;
public class Car : Vehicle, IWheel, ITransmission, IEngine
{
    public uint HorsePower { get; set; }
    public float TankSize { get; set; }
    public float CurrentOil { get; set; }
    /// <summary>
    /// 1 -> Benzin
    /// 2 -> Dizel
    /// 3 -> Qaz
    /// 4 -> Elektrik
    /// 5 -> Hibrit
    /// </summary>
    public byte FuelType { get; set; }
    /// <summary>
    /// true -> Auto
    /// false -> Manual
    /// </summary>
    public bool TransmissionKind { get; set; }
    public float WheelThickness { get; set; }
    public byte DoorCount { get; set; }
    public string WinCode { get; set; }
    public float RemainOilAmount()
       => TankSize - CurrentOil;
    public override string ToString()
    {
        return $"DoorCount : {DoorCount}, CurrentOil : {CurrentOil},DriveTime : {DriveTime},DrivePath : {DrivePath},WinCode : {WinCode}";
    }
}
