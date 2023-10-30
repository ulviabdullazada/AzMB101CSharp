namespace Core.Interfaces;

public interface IEngine
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
    public float RemainOilAmount();
}
