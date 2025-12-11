namespace SIMS.Data
{
    public class Transcript
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public double TotalScore { get; set; }
    }
}