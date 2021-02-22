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
    public class DebitsController : ControllerBase
    {
        IDebitService _debitService;

        public DebitsController(IDebitService debitService)
        {
            _debitService = debitService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _debitService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getalldebitdetails")]
        public IActionResult GetAllDebitDetails()
        {
            var result = _debitService.GetAllDebitDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Debit debit)
        {
            var result = _debitService.Add(debit);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Debit debit)
        {
            var result = _debitService.Delete(debit);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(Debit debit)
        {
            var result = _debitService.Update(debit);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
