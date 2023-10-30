namespace Core.Models;

public abstract class Vehicle
{
    /// <summary>
    /// Neche saat yolda oldugu
    /// </summary>
    public float DriveTime { get; set; }
    /// <summary>
    /// Neche km getdiyi
    /// </summary>
    public float DrivePath { get; set; }
    //public float AvgSpeed { get => DrivePath / DriveTime; }
    /// <summary>
    /// Gedilen yolu gedilen zamana boluruk
    /// </summary>
    /// <returns>Ortalama sureti</returns>
    public float AverageSpeed() => DrivePath / DriveTime;
}
