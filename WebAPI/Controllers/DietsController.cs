using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietsController : ControllerBase
    {
        IDietService _dietService;
        public DietsController(IDietService dietService)
        {
            _dietService = dietService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           
            var result = _dietService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        //[HttpGet("getbyid")]
        //public IActionResult GetById(int id)
        //{
        //    var result = _dietsService.GetByBrandId(id);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        [HttpPost("add")]
        public IActionResult Post(Diet diet)
        {
            var result = _dietService.Add(diet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Diet diet)
        {
            var result = _dietService.Update(diet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Diet diet)
        {
            var result = _dietService.Delete(diet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
