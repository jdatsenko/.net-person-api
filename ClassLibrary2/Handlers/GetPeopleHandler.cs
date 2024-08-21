using ClassLibrary2.Resources;
using ClassLibrary2.Models;
using ClassLibrary2.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Handlers
{
	public class GetPeopleHandler : IRequestHandler<GetPeopleQuery, List<PersonModel>>
	{
		private readonly IPersonResource data;
        public GetPeopleHandler(IPersonResource data)
        {
            this.data = data;
        }

		public Task<List<PersonModel>> Handle(GetPeopleQuery request, CancellationToken cancellationToken)
		{
			return Task.FromResult(data.GetPeople());
		}
	}
}
