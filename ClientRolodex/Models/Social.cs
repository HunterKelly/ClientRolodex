using System.ComponentModel.DataAnnotations.Schema;
namespace ClientRolodex.Models
{
    public class Social
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SocialID { get; set; }
        public string DOB { get; set; }
        public int Age { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
