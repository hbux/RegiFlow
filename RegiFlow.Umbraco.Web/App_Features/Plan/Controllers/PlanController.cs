using RegiFlow.Umbraco.Web.App_Features.Plan.Services;
using RegiFlow.Umbraco.Web.App_Features.Shared.Constants;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace RegiFlow.Umbraco.Web.App_Features.Plan.Controllers
{
    public class PlanController : RenderMvcController
    {
        private readonly IPlanService _planService;

        public PlanController(IPlanService planService)
        {
            _planService = planService;
        }

        [HttpGet]
        public override ActionResult Index(ContentModel model)
        {
            var viewModel = _planService.GetViewModel(model);

            return View(ViewTypes.Plan.View, viewModel);
        }
    }
}