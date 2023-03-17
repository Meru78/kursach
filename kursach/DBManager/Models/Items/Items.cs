using System.Reflection.Metadata;

namespace kursach.DBManager.Models.Items
{
    public class Items
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Blob Image { get; set; }
        public int Count { get; set; }
        public double Coast { get; set; }
        public DateTime CreatedAt { get; set; }
        public int SupplyID { get; set; }
    }
}
