using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TalentSphere.Models.User
{
    public class User
    {

        [Key] // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // IDENTITY (auto-increment)

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
