﻿using RegiFlow.Umbraco.Web.App_Features.Register.Models;
using RegiFlow.Umbraco.Web.App_Features.Register.Services;
using RegiFlow.Umbraco.Web.App_Features.Shared;
using RegiFlow.Umbraco.Web.App_Features.Shared.Constants;
using System.Web.Mvc;
using Umbraco.Web;

namespace RegiFlow.Umbraco.Web.App_Features.Register.Controllers
{
    public sealed class RegisterSurfaceController : BaseSurfaceController
    {
        private readonly IRegisterService _registerService;

        public RegisterSurfaceController(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContinueToPlanSelection(BasicDetailsFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            var umbracoNode = _registerService.ContinueToPlanSelection(model);

            return Redirect(umbracoNode.Url());
        }

        [ChildActionOnly]
        public ActionResult BasicDetails()
        {
            var viewModel = _registerService.GetFormModel();

            return PartialView(ViewTypes.Register.Form, viewModel);
        }
    }
}