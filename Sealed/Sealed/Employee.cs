namespace Sealed;

internal abstract class Employee:Person
{
    public decimal Salary { get; set; }
    public sealed override string GetFullInfo()
    {
        return base.GetFullInfo() + " Salary:" + Salary;
    }

}
