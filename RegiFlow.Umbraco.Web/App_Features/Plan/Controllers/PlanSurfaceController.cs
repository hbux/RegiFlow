using RegiFlow.Umbraco.Web.App_Features.Plan.Models;
using RegiFlow.Umbraco.Web.App_Features.Plan.Services;
using RegiFlow.Umbraco.Web.App_Features.Shared;
using RegiFlow.Umbraco.Web.App_Features.Shared.Constants;
using System.Web.Mvc;

namespace RegiFlow.Umbraco.Web.App_Features.Plan.Controllers
{
    public sealed class PlanSurfaceController : BaseSurfaceController
    {
        private readonly IPlanService _planService;

        public PlanSurfaceController(IPlanService planService)
        {
            _planService = planService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContinueToPayment(PlanFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            return CurrentUmbracoPage();
        }

        [ChildActionOnly]
        public ActionResult PlanSelection()
        {
            var viewModel = _planService.GetFormModel();

            return PartialView(ViewTypes.Plan.Form, viewModel);
        }
    }
}