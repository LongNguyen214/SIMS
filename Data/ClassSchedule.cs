namespace SIMS.Data
{
    public class ClassSchedule
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int SemesterId { get; set; }
        public Semester Semester { get; set; }  
        public string LecturerId { get; set; }
        public ApplicationUser Lecturer { get; set; }
        public DateTime Date { get; set; }
    }
}
