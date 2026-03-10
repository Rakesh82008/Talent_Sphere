using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TalentSphere.Models;

namespace TalentSphereAPI.Models
{
    public class Interview
    {
        [Key]
        public int InterviewID { get; set; }
 
        [Required]
        public int ApplicationID { get; set; }
 
        [Required]
        public DateTime Date { get; set; }
 
        [Required]
        public string Time { get; set; }
 
        [Required]
        public int InterviewerID { get; set; }
 
        [Required]
        public string Status { get; set; }
    }
}
 