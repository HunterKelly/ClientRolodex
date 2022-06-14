namespace ClientRolodex.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }        

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
