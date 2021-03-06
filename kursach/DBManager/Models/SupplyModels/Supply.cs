﻿using System.ComponentModel.DataAnnotations.Schema;

namespace kursach.DBManager.Models.SupplyModels
{
    public class Supply
    {
        [Column("supply_id")]
        public int SupplyId { get; set; }
        [Column("organization")]
        public string Organization { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("supply_date")]
        public DateTime SupplyDate { get; set; }
        [Column("summ")]
        public Double Summ { get; set; }
        [Column("done")]
        public Boolean Done { get; set; }
    }
}
