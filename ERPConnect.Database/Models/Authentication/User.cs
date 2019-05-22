using System;
using System.ComponentModel.DataAnnotations;

namespace ERPConnect.Database.Models.Authentication
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime Created { get; set; }

    }
}