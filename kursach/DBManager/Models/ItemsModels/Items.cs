using kursach.DBManager.Models.SubsidiaryModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace kursach.DBManager.Models.ItemModels
{
    public class Item
    {
        [Column("item_id")]
        public int ItemId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("image")]
        public byte[] Image { get; set; }
        [Column("count")]
        public int Count { get; set; }
        [Column("coast")]
        public double Coast { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("supply_id")] public int SupplyID { get; set; }

        [Column("subsidiary_id")]
        public int SubsidiaryId { get; set; }
        public Subsidiary Subsidiary { get; set; }
    }
}
