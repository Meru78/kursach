using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kursach.DBManager.Models.SellsModels
{
    public class Sells
    {
        [Key]
        [Column("sell_id")]
        public int SellId { get; set; }
        [Column("item_id")]
        public int ItemId { get; set; }
        [Column("count")]
        public int Count { get; set; }
        [Column("coast")]
        public double Coast { get; set; }
        [Column("status")]
        public bool Status { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
