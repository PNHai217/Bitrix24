// Controllers/UsersController.cs
using Bitrix24.Service;
using Bitrix24.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static Bitrix24.Service.UserService;

namespace Bitrix24.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetUsersAsync();
            return View(users);
        }
        public async Task<IActionResult> RefreshUserList()
        {
            var users = await _userService.GetUsersAsync();

            var tableHtml = "<table class='table table-striped table-bordered mt-4' id='userList'>" +
                            "<thead><tr>" +
                            "<th>ID</th>" +
                            "<th>Name</th>" +
                            "<th>Email</th>" +
                            "<th>Last Login</th>" +
                            "<th>User Type</th>" +
                            "</tr></thead><tbody>";

            foreach (var user in users)
            {
                tableHtml += $"<tr>" +
                             $"<td>{user.ID}</td>" +
                             $"<td>{user.LAST_NAME}</td>" +
                             $"<td>{user.EMAIL}</td>" +
                             $"<td>{user.LAST_LOGIN}</td>" +
                             $"<td>{user.USER_TYPE}</td>" +
                             $"</tr>";
            }

            tableHtml += "</tbody></table>";

            return Content(tableHtml);
        }
    }
}
