using Diyetiva.WebApi.Entities;

namespace Diyetiva.WebApi.Dtos.ProductDtos
{
    public class CreateProductDto
    {  
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
       
    }
}
