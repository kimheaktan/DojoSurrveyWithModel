using dojoSurveyWithModel.Models;
using Microsoft.AspNetCore.Mvc;


namespace dojoSurveyWithModel.Controllers
{
    public class ResultController : Controller
    {
        [HttpPost("checking")]
        public IActionResult Checking(Survey survey) 
        {
            if(ModelState.IsValid){
                return RedirectToAction("Success" , survey);
            }
            else{
                return View("Index");
            }

        }
    
        [HttpGet("success")]
        public IActionResult Success(Survey survey)
        {
            // Survey survey = newSurvey;
            return View("Result", survey);

        }
    }

    
}