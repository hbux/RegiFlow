using RegiFlow.Umbraco.Web.App_Features.Register.Services;
using RegiFlow.Umbraco.Web.App_Features.Shared.Constants;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace RegiFlow.Umbraco.Web.App_Features.Register.Controllers
{
    public class RegisterController : RenderMvcController
    {
        private readonly IRegisterService _registerService;

        public RegisterController(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        [HttpGet]
        public override ActionResult Index(ContentModel model)
        {
            var viewModel = _registerService.GetViewModel(model);

            return View(ViewTypes.Register.View, viewModel);
        }
    }
}