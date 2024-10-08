using RegiFlow.Umbraco.Web.App_Features.Plan.Models;
using Umbraco.Web.Models;

namespace RegiFlow.Umbraco.Web.App_Features.Plan.Services
{
    public interface IPlanService
    {
        PlanViewModel GetViewModel(ContentModel model);
        PlanFormModel GetFormModel();
    }

    public class PlanService : IPlanService
    {
        public PlanViewModel GetViewModel(ContentModel model)
        {
            return new PlanViewModel(model.Content);
        }

        public PlanFormModel GetFormModel()
        {
            return new PlanFormModel();
        }
    }
}