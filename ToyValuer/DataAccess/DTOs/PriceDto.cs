namespace ToyValuer.DataAccess.DTOs
{
    public class PriceDto
    {
        public string Sec_ID { get; set; }
        public DateTime Sec_Date { get; set; }
        public string Price_Type { get; set; }
        public decimal Price { get; set; }
    }
}
