using System.ComponentModel.DataAnnotations.Schema;

//фелиал
namespace kursach.DBManager.Models.SubsidiaryModels
{
    public class Subsidiary
    {
        [Column("subsidiary_id")]
        public int SubsidiaryId { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("addres")]
        public string Addres { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
    }
}
