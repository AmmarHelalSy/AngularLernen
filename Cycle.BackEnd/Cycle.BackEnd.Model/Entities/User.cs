namespace Cycle.BackEnd.Model.Entities
{
    public sealed class User
    {
        public Guid Id { get; set; }
        
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? EmailAddress { get; set; }
        public long? PersonnelNumber { get; set; }

        public required ICollection<Booking> Bookings { get; set; }
        public required WorkingHours WorkingHours { get; set; }
    }
}