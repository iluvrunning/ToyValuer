namespace ToyValuer.DataAccess.DTOs
{
    public class BalanceDto
    {
        public int BalID { get; set; }
        public string Folio { get; set; }
        public string Curr { get; set; }
        public int Account { get; set; }
        public string Sec { get; set; }
        public DateTime BalDate { get; set; }
        public int Balance { get; set; }

    }
}
