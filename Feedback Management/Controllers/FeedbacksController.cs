using Microsoft.AspNetCore.Mvc;
using Feedback_Management.Models;
using Feedback_Management.Services;

namespace Feedback_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbacksController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbacksController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService ?? throw new ArgumentNullException(nameof(feedbackService));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_feedbackService.GetFeedbacks());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var feedback = _feedbackService.GetFeedback(id);
            if (feedback != null)
            {
                return Ok(feedback);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Feedback feedback)
        {
            var newFeedback = _feedbackService.AddFeedback(feedback);
            return CreatedAtAction(nameof(Get), new { id = newFeedback.Feedback_ID }, newFeedback);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Feedback feedback)
        {
            var updatedFeedback = _feedbackService.UpdateFeedback(id, feedback);
            if (updatedFeedback != null)
            {
                return Ok(updatedFeedback);
            }
            return NotFound();
        }
       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _feedbackService.DeleteFeedback(id);
            if (result == true)
            {
                return Ok($"Feedback with ID:{id} got deleted successfully.");
            }
            return NotFound($"Unable to delete the feedback with ID:{id}.");
        }

    }
}
