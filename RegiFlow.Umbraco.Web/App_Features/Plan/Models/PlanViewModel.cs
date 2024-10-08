using Umbraco.Core.Models.PublishedContent;

namespace RegiFlow.Umbraco.Web.App_Features.Plan.Models
{
    public class PlanViewModel : App_Data.Models.Plan
    {
        public PlanViewModel(
            IPublishedContent content) 
            : base(content)
        {
        }
    }
}