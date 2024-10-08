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
    }
}