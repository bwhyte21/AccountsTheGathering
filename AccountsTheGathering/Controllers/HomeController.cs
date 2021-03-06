using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using AccountsTheGathering_Models.ViewModels;

namespace AccountsTheGathering.Controllers
{
    public class HomeController : Controller
    {
        // Http client
        private static readonly HttpClient Client = new HttpClient();
        private const string FrontierGetAll = "https://frontiercodingtests.azurewebsites.net/api/accounts/getall";

        /// <summary>
        /// Account Status Enum
        /// </summary>
        public enum AccountStatuses
        {
            Active,
            Inactive,
            Overdue
        }

        /// <summary>
        /// The main goods of this page.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            #region Long Path
            // Prep a variable to return the user accounts to the view.
            //List<UserAccountViewModel> userAccounts;

            // Using this using to insure a successful open/close connection
            //using (var httpClient = new HttpClient())
            //{
                //using var response = await httpClient.GetAsync("https://frontiercodingtests.azurewebsites.net/api/accounts/getall");
                //var apiResponse = await response.Content.ReadAsStringAsync();
                //userAccounts = JsonConvert.DeserializeObject<List<UserAccount>>(apiResponse);
            //}
            #endregion

            #region Short Path
            // Use a stream instead of a string as the source.
            var streamTask = Client.GetStreamAsync(FrontierGetAll);
            // Deserialize the json into objects for the razor page.
            var userAccounts = await JsonSerializer.DeserializeAsync<List<UserAccountViewModel>>(await streamTask);
            #endregion

            return View(userAccounts);
        }

        /// <summary>
        /// Error page that comes with default MVC project.
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}