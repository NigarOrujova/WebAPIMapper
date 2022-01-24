using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIApp2.Data.DAL;
using WebAPIApp2.Data.Entities;
using WebAPIApp2.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIApp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProductsController(AppDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<ActionResult<List<ProductGetDto>>> Get()
        {
            List<ProductGetDto> products=_mapper.Map<List<ProductGetDto>>( await _context.Products.Where(p => p.IsDeleted == false).ToListAsync());
            return products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductGetDto>> Get(int id)
        {
            Product product = await _context.Products.Where(p => p.IsDeleted == false && p.Id == id).FirstOrDefaultAsync();
            if (product is null) return NotFound();
            ProductGetDto productGetDto = _mapper.Map<ProductGetDto>(product);
            return productGetDto;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult> Post(ProductPostDto productPostDto)
        {
            Product product = _mapper.Map<Product>(productPostDto);
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
