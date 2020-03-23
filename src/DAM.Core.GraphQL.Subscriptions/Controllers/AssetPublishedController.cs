using DAM.Core.GraphQL.Subscriptions.Interfaces;
using DAM.Core.Messages.AssetDomain;
using Microsoft.AspNetCore.Mvc;

namespace DAM.Core.GraphQL.Subscriptions.Controllers
{
    [Route("events/AssetPublished")]
    public class AssetPublishedController : Controller
    {
        private readonly ISubscriptionService<AssetPublishedEvent> _service;

        public AssetPublishedController(ISubscriptionService<AssetPublishedEvent> service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Notify([FromBody]AssetPublishedEvent e)
        {
            _service.Notify(e);

            return Ok();
        }
    }
}
