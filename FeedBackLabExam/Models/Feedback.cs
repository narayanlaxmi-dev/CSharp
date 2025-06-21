namespace FeedBackLabExam.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string? SubmittedBy { get; set; }
        public string? Message { get; set; }

        // current dateTime
        public DateTime? SubmittedOn { get; set; } = DateTime.Now;
        public string? Feedbacktype { get; set; }
    }
}
