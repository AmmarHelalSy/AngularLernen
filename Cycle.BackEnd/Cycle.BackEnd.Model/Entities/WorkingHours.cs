namespace Cycle.BackEnd.Model.Entities
{
    public sealed class WorkingHours
    {
        public Guid Id { get; set; }

        public float? Monday { get; set; }
        public float? Tuesday { get; set; }
        public float? Wednesday { get; set; }
        public float? Thursday { get; set; }
        public float? Friday { get; set; }
        public float? Saturday { get; set; }
        public float? Sunday { get; set; }
        
        public required User User { get; set; }
    }
}