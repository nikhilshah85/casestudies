using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Productmicroservice.Models;
using Productmicroservice.Repository;
namespace Productmicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors(PolicyName = "clientA")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _Iproduct;

        public ProductController(IProductRepository productRepositoryRef)
        {
            _Iproduct = productRepositoryRef;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_Iproduct.GetProducts());
        }
        [HttpPost]
        public IActionResult Post(Product newProduct)
        {
            return Created("",_Iproduct.AddProduct(newProduct));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_Iproduct.DeleteProduct(id));
        }

        [HttpPut]
        public IActionResult Put(Product updatedProduct)
        {
            return Ok(_Iproduct.UpdateProduct(updatedProduct));
        }
    }
}





