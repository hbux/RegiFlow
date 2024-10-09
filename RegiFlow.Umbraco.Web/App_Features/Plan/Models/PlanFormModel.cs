using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegiFlow.Umbraco.Web.App_Features.Plan.Models
{
    public class PlanFormModel
    {
        [Required(ErrorMessage = "Please choose a plan")]
        [DisplayName("Choose a plan")]
        public Guid Plan { get; set; }
    }
}