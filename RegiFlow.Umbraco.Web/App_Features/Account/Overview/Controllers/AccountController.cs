using RegiFlow.Umbraco.Web.App_Features.Account.Overview.Services;
using RegiFlow.Umbraco.Web.App_Features.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace RegiFlow.Umbraco.Web.App_Features.Account.Overview.Controllers
{
    public sealed class AccountController : RenderMvcController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public override ActionResult Index(ContentModel model)
        {
            var viewModel = _accountService.GetViewModel(model);

            return View(ViewTypes.Account.View, viewModel);
        }
    }
}