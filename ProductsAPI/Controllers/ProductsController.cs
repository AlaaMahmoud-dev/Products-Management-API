using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsBusiness;
using ProductsModels;

namespace ProductsAPI.Controllers
{
    [Route("api/Products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet("All",Name ="GetAllProducts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<ProductDTO>> GetAllProducts()
        {
            List<ProductDTO> products = clsProduct.GetProducts();
            if (products == null)
                return NotFound("There is no products found.");

            return Ok(products);
        }
        [HttpGet("{id}", Name = "GetInfoByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ProductDTO> GetInfobyID(int id)
        {
            if (id < 1)
            {
                return BadRequest($"ID {id} is not valid.");
            }
            clsProduct product = clsProduct.GetInfoByID(id);
            if (product == null)
            {
                return NotFound($"Product With ID {id} Was Not Found.");
            }
            return Ok(product.productDTO);
        }

        [HttpGet("Search", Name = "SearchByName")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<ProductDTO>> Search(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest($"name cannot be empty.");
            }
            List<ProductDTO> products = clsProduct.Search(name);
            if (products == null)
                return NotFound();

            return Ok(products);
        }



        [HttpPost("AddNew", Name = "AddNewProduct")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ProductDTO> AddNewProduct(ProductDTO productDTO)
        {
            if (productDTO == null)
            {
                return BadRequest("There is no data available to be stored");

            }
            clsProduct productInfo = new clsProduct();
            productInfo.ProductName = productDTO.ProductName;
            productInfo.Price = productDTO.Price;
            productInfo.Quantity = productDTO.Quantity;
            productInfo.Tax = productDTO.Tax;
            productInfo.CreatedAt = productDTO.CreatedAt;
            if (productInfo.Save())
            {
                productDTO.Id = productInfo.Id;
                return CreatedAtRoute("GetInfoByID", new { Id = productInfo.Id }, productDTO);
            }
            return StatusCode(500, new { message = "Adding New Product Was Failed." });
        }

        [HttpPut("Update", Name = "UpdateProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ProductDTO> UpdateProduct(ProductDTO productDTO)
        {
            if (productDTO == null || productDTO.Id < 1)
            {
                return BadRequest("Given Information is not valid");

            }
            clsProduct productInfo = clsProduct.GetInfoByID(productDTO.Id);
            if (productInfo==null)
            {
                return NotFound($"Product with id {productDTO.Id} was not found");
            }
            productInfo.ProductName = productDTO.ProductName;
            productInfo.Price = productDTO.Price;
            productInfo.Quantity = productDTO.Quantity;
            productInfo.Tax = productDTO.Tax;
            if (productInfo.Save())
            {
                
                return Ok(productDTO);
            }
            return StatusCode(500,new { message = "Updating Product Data Was Failed." });
        }


        [HttpDelete("{id}", Name = "DeleteProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteProduct(int id)
        {
            if (id < 1)
            {
                return BadRequest("Given Id is not valid");

            }
            clsProduct productInfo = clsProduct.GetInfoByID(id);
            if (productInfo == null)
            {
                return NotFound($"Product with id {id} was not found");
            }
            if (productInfo.Delete())
            {
                return Ok("Deleted Successfully");
            }
            return StatusCode(500, new { message = "Selected product connot be deleted because there is data linked to it." });
        }




    }
}
