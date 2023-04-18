using Feedback_Management.Data;
using Feedback_Management.Models;

namespace Feedback_Management.Services
{
    public class FeedbackService : IFeedbackService
    {
        public List<Feedback> GetFeedbacks()
        {
            return FeedbackMockDataService.FeedbackList;
        }

        public Feedback? GetFeedback(int id)
        {
            return FeedbackMockDataService.FeedbackList.FirstOrDefault(x => x.Feedback_ID == id);
        }

        public Feedback? AddFeedback(Feedback feedback)
        {
            FeedbackMockDataService.FeedbackList.Add(feedback);
            return feedback;
        }

        public Feedback? UpdateFeedback(Feedback feedback)
        {
            Feedback selectedFeedback = FeedbackMockDataService.FeedbackList.FirstOrDefault(x => x.Feedback_ID == feedback.Feedback_ID);
            if (selectedFeedback != null)
            {
                selectedFeedback.Feedback_ID = feedback.Feedback_ID;
                selectedFeedback.Feedback_Date = feedback.Feedback_Date;
                selectedFeedback.Feedback_Source = feedback.Feedback_Source;
                selectedFeedback.Feedback_Category = feedback.Feedback_Category;
                selectedFeedback.Feedback_Description = feedback.Feedback_Description;
                selectedFeedback.Customer_Name = feedback.Customer_Name;
                selectedFeedback.Customer_Email = feedback.Customer_Email;
                selectedFeedback.Feedback_Rating = feedback.Feedback_Rating;
                return selectedFeedback;
            }
            return null;
        }

        public bool? DeleteFeedback(int id)
        {
            Feedback selectedFeedback = FeedbackMockDataService.FeedbackList.FirstOrDefault(x => x.Feedback_ID == id);
            if (selectedFeedback != null)
            {
                FeedbackMockDataService.FeedbackList.Remove(selectedFeedback);
                return true;
            }
            return false;
        }
    }
}
