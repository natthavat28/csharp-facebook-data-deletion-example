using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Facebook.DataDeleteExample
{
    [Route("fb")]
    public class FacebookController : Controller
    {
        [HttpPost("user_remove_request")]
        public async Task<ActionResult<RemoveRequestResponseModel>> CreateRemoveRequest(string key, [FromForm] RemoveRequestContainerModel request)
        {
            // verify request process

            // verify facebook account process

            // delete user process

            // create data-delete request ticket id
            var requestId = Guid.NewGuid().ToString();

            return Ok(new RemoveRequestResponseModel
            {
                Url = $"https://yourdomain.com/{Url.Action("ViewRemoveRequest", "Facebook", new { requestId = requestId })}",
                ConfirmationCode = requestId
            });
        }

        [HttpGet("remove-request/{requestId}")]
        public async Task<IActionResult> ViewRemoveRequest(string requestId)
        {
            if (string.IsNullOrEmpty(requestId))
            {
                return NotFound();
            }

            // get data-delete info from id

            return View(new RequestDeleteInfo {

            });
        }
    }
}