using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using DemoLibrary.Models;	

namespace DemoLibrary.Queries
{
	public record GetPersonListQuery() : IRequest<List<PersonModel>>;

}
