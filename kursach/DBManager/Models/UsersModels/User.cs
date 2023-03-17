﻿using System.ComponentModel.DataAnnotations.Schema;

namespace kursach.DBManager.Models.UserModels
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public string RightType { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}