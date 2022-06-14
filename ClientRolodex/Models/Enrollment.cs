using System.ComponentModel.DataAnnotations;
namespace ClientRolodex.Models
{
    public enum Credit
    {
        Bad,
        Poor,
        Fair,
        Good,
        Great,
        Excellent
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int SocialID { get; set; }
        public int DriverID { get; set; }
        [DisplayFormat(NullDisplayText = "Unknown")]
        public Credit? Credit { get; set; }

        public Social Social { get; set; }
        public Driver Driver { get; set; }
    }
}
