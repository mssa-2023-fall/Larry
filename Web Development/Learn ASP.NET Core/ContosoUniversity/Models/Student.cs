namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        //If I don't use List<Enrollment> or other collection types: ICollection is defaulted to HashSet<Enrollment> by default with EF Core
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
