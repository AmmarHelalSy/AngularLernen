namespace Cycle.BackEnd.Model.Entities
{
    public sealed class Booking
    {
        public Guid Id { get; set; }        
        
        public DateTime TimeStamp { get; set; }
        public BookingTypes BookingType { get; set; }
        
        public required User User { get; set; }
    }
}