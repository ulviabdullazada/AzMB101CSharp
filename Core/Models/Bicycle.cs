using Core.Interfaces;

namespace Core.Models
{
    public class Bicycle : Vehicle, IWheel
    {
        public byte PedalKind { get; set; }
        public float WheelThickness { get; set; }
    }
}
