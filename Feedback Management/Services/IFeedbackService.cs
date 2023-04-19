using Feedback_Management.Models;
using System.Collections.Generic;

namespace Feedback_Management.Services
{
    public interface IFeedbackService
    {
        // Get all feedbacks
        List<Feedback> GetFeedbacks();

        // Get feedback by ID
        Feedback? GetFeedback(int id);

        // Add a new feedback
        Feedback? AddFeedback(Feedback feedback);

        // Update an existing feedback
        Feedback? UpdateFeedback(int id, Feedback feedback);

        // Delete a feedback by ID
        bool? DeleteFeedback(int id);
    }
}
