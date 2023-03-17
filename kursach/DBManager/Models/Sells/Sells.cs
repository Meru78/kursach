namespace kursach.DBManager.Models.Sells
{
    public class Sells
    {
        public int SellId { get; set; }
        public int ItemId { get; set; }
        public int Count { get; set; }
        public double Coast { get; set; }
        public int Status { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
