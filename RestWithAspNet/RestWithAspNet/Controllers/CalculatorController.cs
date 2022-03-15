﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithAspNet.utils;

namespace RestWithAspNet.Controllers
{
    [ApiController]
    [Route("")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber)
        {
            if (Maths.IsNumeric(firstNumber) && Maths.IsNumeric(secondNumber))
            {
                var sum = Maths.ConvertToDecimal(firstNumber) + Maths.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult Multi(string firstNumber, string secondNumber)
        {
        }
    }
}