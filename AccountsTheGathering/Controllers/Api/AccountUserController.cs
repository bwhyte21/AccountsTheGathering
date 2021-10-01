using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountsTheGathering_Models.ViewModels;

namespace AccountsTheGathering.Controllers.Api
{
  [Route("api/[controller]")]
  [ApiController]
  public class AccountUserController : ControllerBase // Deriving from ControllerBase as there is no need for view support for this controller.
  {
      //private readonly List<UserAccountViewModel> _userAccounts = new List<UserAccountViewModel>();

      /// <summary>
      /// Returns list of all user accounts.
      /// </summary>
      /// <returns></returns>
      [HttpGet]
      public ActionResult<List<UserAccountViewModel>> GetAccounts()
      {
          //return _userAccounts;
          
          // Return list of all accounts.
          return new List<UserAccountViewModel>();
      }
  }
}
