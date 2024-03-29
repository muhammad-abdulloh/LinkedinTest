using Linkedin.Domain.Entities.DTOs;
using Linkedin.Domain.Entities.Models;
using MediatR;

namespace Linkedin.Application.UseCases.Users.Commands
{
    public class CreateUserCommand : UserDTO, IRequest<User>
    {
        
    }
}
