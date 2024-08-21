using ClassLibrary2.Models;
using ClassLibrary2.Queries;
using ClassLibrary2.Resources;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Handlers
{
	public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
	{
		private readonly IMediator mediator;
		public GetPersonByIdHandler(IMediator mediator)
		{
			this.mediator = mediator;
		}
		public async Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
		{
			var results = await mediator.Send(new GetPeopleQuery());
			var output = results.FirstOrDefault(x => x.Id == request.Id);
			return output;
		}	
	}
}
