using System.ComponentModel.DataAnnotations;

namespace dojoSurveyWithModel.Models
{
    public class Survey
    {
        [Required(ErrorMessage ="Required")]
        [MinLength(2, ErrorMessage = "Name has to be at least 2 characters")]
        public string Name{get;set;}

        [Required(ErrorMessage ="Required")]
        public string Location{get;set;}

        [Required(ErrorMessage ="Required")]
        // [Display(Name = "Language")]
        public string Language{get;set;}

        [MinLength(20, ErrorMessage = " has to be at least 20 characters")]

        public string Comment{get;set;}
    }
}