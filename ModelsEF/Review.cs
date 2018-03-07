namespace ModelsEF
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Source { get; set; }
        public string SourceType { get; set; }
        public string ReviewText { get; set; }
        public string Grade { get; set; }
        public string GradeType { get; set; }
    }
}