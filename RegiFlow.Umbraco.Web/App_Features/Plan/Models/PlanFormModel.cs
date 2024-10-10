using Newtonsoft.Json;
using RegiFlow.Umbraco.Web.App_Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.ModelBinding;

namespace RegiFlow.Umbraco.Web.App_Features.Plan.Models
{
    public class PlanFormModel
    {
        public PlanFormModel()
        {
            SubscriptionPlans = Enumerable.Empty<Subscription>();
        }

        [Required(ErrorMessage = "Please choose a plan")]
        [DisplayName("Choose a plan")]
        public Guid SubscriptionPlanId { get; set; }

        [JsonIgnore]
        [BindNever]
        public IEnumerable<Subscription> SubscriptionPlans { get; set; }
    }
}