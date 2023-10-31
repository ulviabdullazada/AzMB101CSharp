namespace Core.Interfaces;

public interface ITransmission
{
    /// <summary>
    /// true -> Auto
    /// false -> Manual
    /// </summary>
    public bool TransmissionKind { get; set; }
}
