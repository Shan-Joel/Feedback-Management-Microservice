namespace Feedback_Management.Models
{
    public class Feedback
    {
        public int Feedback_ID { get; set; }
        public string? Feedback_Date { get; set; }
        public string? Feedback_Source { get; set; }
        public string? Feedback_Category { get; set; }
        public string? Feedback_Description { get; set; }
        public string? Customer_Name { get; set; }
        public string? Customer_Email { get; set; }
        public string? Feedback_Rating { get; set; }
        
    }
}
