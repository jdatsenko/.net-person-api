using ClassLibrary2.Command;
using ClassLibrary2.Models;
using ClassLibrary2.Resources;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Handlers
{
	public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
	{
		private readonly IPersonResource data;
        public InsertPersonHandler(IPersonResource data)
        {
            this.data = data;
        }
        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
		{
			return Task.FromResult(data.InsertPerson(request.Name));
		}
	}
}
