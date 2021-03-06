using System;
using AuthenticationServiceConsumer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationServiceConsumer.Controllers
{
    // public class AuthorizeAttribute : Attribute, IAuthorizeData
    // public interface IAuthorizeData

    // [Authorize] is it a filter? Is it a part of MVC filter pipeline?

    // Note: You will have to use Authentication middleware in order to use [Authorize] attribute.
    // Go to the Startup.cs and add the following code: app.UseAuthentication().

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new Product[] {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "The first product"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "The second product"
                }
            });
        }
    }
}