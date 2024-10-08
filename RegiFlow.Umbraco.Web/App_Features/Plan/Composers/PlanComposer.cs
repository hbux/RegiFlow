using RegiFlow.Umbraco.Web.App_Features.Plan.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace RegiFlow.Umbraco.Web.App_Features.Plans.Composers
{
    public class PlanComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<IPlanService, PlanService>(Lifetime.Scope);
        }
    }
}