using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UbBankAccountApi.Models;

namespace UbBankAccountApi.Controllers
{
    [Route("bankingrest/api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private static readonly List<AccountModel> account_details = [];

        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<AccountModel> GetAccountDetails()
        {
            return account_details;
        }

        [HttpPost]
        public IActionResult PostAccountDetails(AccountModel account_Details)
        {
            account_details.Add(account_Details);
            return Ok(account_details);
        }
    }
}
