using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
	
	[ApiController]
	public class Api1Controller : ControllerBase
	{	

		[Route("taxaJuros")]
		[HttpGet]
		public decimal Get()
		{
			decimal taxaJuros = Util.TaxaJuros;
			return taxaJuros;
		}
	}
}
