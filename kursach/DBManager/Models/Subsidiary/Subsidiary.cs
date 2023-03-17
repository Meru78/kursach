namespace kursach.DBManager.Models.Subsidiary
{
    public class Subsidiary
    {
        public int SubsidiaryId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
    }
}
