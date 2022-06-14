using System.ComponentModel.DataAnnotations.Schema;
namespace ClientRolodex.Models
{
    public class Driver
    {
           [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int DriverID { get; set; }
            public string? LicenseType { get; set; }
            public int Tickets { get; set; }

            public ICollection<Enrollment> Enrollments { get; set; }
        
    }
}
