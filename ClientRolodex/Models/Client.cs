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

    //public static ClientSearch()
   // {

   // }
    //Query the Database
//    using (var db = new BloggingContext())
//{
//    var blogs = db.Blogs
//        .Where(b => b.Rating > 3)
//        .OrderBy(b => b.Url)
//        .ToList();
//}
}
