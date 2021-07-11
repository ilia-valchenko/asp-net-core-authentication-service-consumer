using System;
using AuthenticationServiceConsumer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationServiceConsumer.Controllers
{
    // public class AuthorizeAttribute : Attribute, IAuthorizeData
    // public interface IAuthorizeData

    // [Authorize] is it a filter? Is it a part of MVC filter pipeline?

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