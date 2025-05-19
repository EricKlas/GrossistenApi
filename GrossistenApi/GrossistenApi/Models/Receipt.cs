namespace GrossistenApi.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public int? ReceiptProductId { get; set; }
        public string? PersonName { get; set; }
        public DateTime? Incoming { get; set; }
        public DateTime? Outgoing { get; set; }
        public bool? IncomingReceipt { get; set; }
        public bool? OutgoingReceipt { get; set; }

    }
}
