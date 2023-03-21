using System.ComponentModel.DataAnnotations.Schema;

namespace kursach.DBManager.Models.UserModels
{
    public class User
    {
        [Column("id_user")]
        public int UserId { get; set; }
        [Column("FIO")]
        public string FIO { get; set; }
        [Column("login")]
        public string Login { get; set; }
        [Column("password_hash")]
        public string PasswordHash { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("right_type")]
        public string RightType { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
    }
}
