using AccountsTheGathering_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AccountsTheGathering.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountUserController : ControllerBase // Deriving from ControllerBase as there is no need for view support for this controller.
    {
        /// <summary>
        /// Returns list of all user accounts.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<UserAccountViewModel>> GetAccounts()
        {
            // Return list of all accounts.
            return new List<UserAccountViewModel>();
        }
    }
}