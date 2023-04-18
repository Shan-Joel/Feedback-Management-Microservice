namespace Feedback_Management.Services
{
    public interface IFeedbackService
    {
        // Get all feedbacks
        List<Models.Feedback> GetFeedbacks();

        // Get feedback by ID
        Models.Feedback? GetFeedback(int id);

        // Add a new feedback
        Models.Feedback? AddFeedback(Models.Feedback feedback);

        // Update an existing feedback
        Models.Feedback? UpdateFeedback(Models.Feedback feedback);

        // Delete a feedback by ID
        bool? DeleteFeedback(int id); 
    }
}
