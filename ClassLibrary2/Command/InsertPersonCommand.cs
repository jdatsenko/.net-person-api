using ClassLibrary2.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Command
{
	public record InsertPersonCommand(string Name) : IRequest<PersonModel>;
}
