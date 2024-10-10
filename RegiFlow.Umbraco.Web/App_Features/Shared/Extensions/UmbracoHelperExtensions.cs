using RegiFlow.Umbraco.Web.App_Data.Models;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Web;

namespace RegiFlow.Umbraco.Web.App_Features.Shared.Extensions
{
    public static class UmbracoHelperExtensions
    {
        public static App_Data.Models.Register GetRegisterNode(this UmbracoHelper helper)
        {
            var node = helper
                .ContentAtRoot()
                .DescendantsOrSelf<App_Data.Models.Register>()
                .First();

            return node;
        }

        public static App_Data.Models.Plan GetPlanNode(this UmbracoHelper helper)
        {
            var node = helper
                .ContentAtRoot()
                .DescendantsOrSelf<App_Data.Models.Plan>()
                .First();

            return node;
        }

        public static IEnumerable<Subscription> GetSubscriptionPlans(this UmbracoHelper helper)
        {
            var planNode = helper.GetPlanNode();

            if (planNode == null || planNode.Subscriptions == null)
            {
                return Enumerable.Empty<Subscription>();
            }

            var subscriptionPlans = Enumerable.Empty<Subscription>();

            try
            {
                subscriptionPlans = planNode.Subscriptions.Select(x => x.Content) as IEnumerable<Subscription>;

                return subscriptionPlans;
            }
            catch
            {
                return Enumerable.Empty<Subscription>();
            }
        }
    }
}