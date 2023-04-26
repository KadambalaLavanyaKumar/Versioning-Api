using Microsoft.AspNetCore.Mvc;
using Versioning_Api.Models.Dto;

namespace Versioning_Api.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class MobilesController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet]
        public IActionResult GetV1()
        {
            var mobileDomainModel = MobileData.Get();

            var response = new List<MobileDtoV1>();
            foreach (var mobileDomain in mobileDomainModel)
            {
                response.Add(new MobileDtoV1
                {
                    Id = mobileDomain.Id,
                    Name = mobileDomain.Name
                });
            }
            return Ok(response);
        }

        [MapToApiVersion("2.0")]
        [HttpGet]
        public IActionResult GetV2()
        {
            var mobileDomainModel = MobileData.Get();

            var response = new List<MobileDtoV2>();
            foreach (var mobileDomain in mobileDomainModel)
            {
                response.Add(new MobileDtoV2
                {
                    Id = mobileDomain.Id,
                    MobileName = mobileDomain.Name
                });
            }
            return Ok(response);
        }
    }
}
