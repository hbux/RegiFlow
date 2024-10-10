using RegiFlow.Umbraco.Web.App_Data.Models;
using RegiFlow.Umbraco.Web.App_Features.Plan.Models;
using RegiFlow.Umbraco.Web.App_Features.Shared.Extensions;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Web;
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
        private readonly UmbracoHelper _umbracoHelper;

        public PlanService(UmbracoHelper umbracoHelper)
        {
            _umbracoHelper = umbracoHelper;
        }

        public PlanViewModel GetViewModel(ContentModel model)
        {
            return new PlanViewModel(model.Content);
        }

        public PlanFormModel GetFormModel()
        {
            var subscriptionPlans = _umbracoHelper.GetSubscriptionPlans();

            return new PlanFormModel()
            {
                SubscriptionPlans = subscriptionPlans
            };
        }
    }
}