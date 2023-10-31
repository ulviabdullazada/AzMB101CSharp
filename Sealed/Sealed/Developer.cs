namespace Sealed;
internal sealed class Developer : Employee
{
    public bool IsBackEnd { get; set; }
    public override void SayHi()
    {
        base.SayHi();
    }
}
