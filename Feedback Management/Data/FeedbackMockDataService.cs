namespace Feedback_Management.Data
{
    public class FeedbackMockDataService
    {
        public static List<Models.Feedback> FeedbackList = new List<Models.Feedback>()
        {
            new Models.Feedback
            {
                Feedback_ID = 1,
                Feedback_Date = "2023-04-18",
                Feedback_Source = "website form",
                Feedback_Category = "product quality",
                Feedback_Description = "The website crashed while I was making a purchase",
                Customer_Name = "Jane Doe",
                Customer_Email = "jane.doe@example.com",
                Feedback_Rating = "2/5"
            },
            new Models.Feedback
            {
                Feedback_ID = 2,
                Feedback_Date = "2023-04-17",
                Feedback_Source = "social media",
                Feedback_Category = "customer service",
                Feedback_Description = "I've been waiting on hold for an hour",
                Customer_Name = "John Smith",
                Customer_Email = "john.smith@example.com",
                Feedback_Rating = "1/5"
            },
            new Models.Feedback
            {
                Feedback_ID = 3,
                Feedback_Date = "2023-04-16",
                Feedback_Source = "email",
                Feedback_Category = "product quality",
                Feedback_Description = "The product I received is not what I ordered",
                Customer_Name = "Bob Johnson",
                Customer_Email = "bob.johnson@example.com",
                Feedback_Rating = "3/5"
            },
            new Models.Feedback
            {
                Feedback_ID = 4,
                Feedback_Date = "2023-04-15",
                Feedback_Source = "phone call",
                Feedback_Category = "customer service",
                Feedback_Description = "The representative was very helpful",
                Customer_Name = "Mary Smith",
                Customer_Email = "mary.smith@example.com",
                Feedback_Rating = "4/5"
            },
            new Models.Feedback
            {
                Feedback_ID = 5,
                Feedback_Date = "2023-04-14",
                Feedback_Source = "social media",
                Feedback_Category = "product quality",
                Feedback_Description = "The product arrived damaged",
                Customer_Name = "Emily Johnson",
                Customer_Email = "emily.johnson@example.com",
                Feedback_Rating = "2/5"
            },
            new Models.Feedback
            {
                Feedback_ID = 6,
                Feedback_Date = "2023-04-13",
                Feedback_Source = "website form",
                Feedback_Category = "customer service",
                Feedback_Description = "I'm having trouble logging in",
                Customer_Name = "David Lee",
                Customer_Email = "david.lee@example.com",
                Feedback_Rating = "3/5"
            },
            new Models.Feedback
            {
                Feedback_ID = 7,
                Feedback_Date = "2023-04-12",
                Feedback_Source = "email",
                Feedback_Category = "product quality",
                Feedback_Description = "The product is not as described",
                Customer_Name = "Alice Wong",
                Customer_Email = "alice.wong@example.com",
                Feedback_Rating = "2/5"
            },
            new Models.Feedback
            {
                Feedback_ID = 8,
                Feedback_Date = "2023-04-11",
                Feedback_Source = "phone call",
                Feedback_Category = "customer service",
                Feedback_Description = "I'm having trouble with my account",
                Customer_Name = "Tom Chen",
                Customer_Email = "tom.chen@example.com",
                Feedback_Rating = "4/5"
            },
            new Models.Feedback
            {
                Feedback_ID = 9,
                Feedback_Date = "2023-04-10",
                Feedback_Source = "social media",
                Feedback_Category = "product quality",
                Feedback_Description = "I never received my order",
                Customer_Name = "Karen Lee",
                Customer_Email = "karen.lee@example.com",
                Feedback_Rating = "1/5"
            },
            new Models.Feedback
            {
                Feedback_ID = 10,
                Feedback_Date = "2023-04-09",
                Feedback_Source = "website form",
                Feedback_Category = "customer service",
                Feedback_Description = "The website is difficult to navigate",
                Customer_Name = "Michael Johnson",
                Customer_Email = "michael.johnson@example.com",
                Feedback_Rating = "3/5"
            }
        };
    }
}