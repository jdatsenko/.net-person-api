using ClassLibrary2.Command;
using ClassLibrary2.Models;
using ClassLibrary2.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{

		private readonly IMediator _mediator;

		public PersonController(IMediator mediator)
		{
			_mediator = mediator;
		}
		// GET: api/<PersonController>
		[HttpGet]
		public async Task<List<PersonModel>> Get()
		{
			return await _mediator.Send(new GetPeopleQuery());
		}

		// GET api/<PersonController>/5
		[HttpGet("{id}")]
		public async Task<PersonModel> Get(int id)
		{
			return await _mediator.Send(new GetPersonByIdQuery(id));
		}

		// POST api/<PersonController>
		[HttpPost]
		public async Task<PersonModel> Post([FromBody] PersonModel value)
		{
			var model = new InsertPersonCommand(value.Name);
			return await _mediator.Send(model);
		}

		// PUT api/<PersonController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<PersonController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
