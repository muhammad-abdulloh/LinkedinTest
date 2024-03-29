using Linkedin.Application.Abstractions;
using Linkedin.Application.UseCases.Users.Commands;
using Linkedin.Domain.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.Application.UseCases.Users.Handlers.CommandHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, User>
    {
        private readonly ILinkedinDbContext _context;

        public CreateUserCommandHandler(ILinkedinDbContext context)
        {
            _context = context;
        }

        public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                Password = request.Password,
                ConfirmPassword = request.ConfirmPassword,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
            };


            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync(cancellationToken);

            return user;

        }
    }
}
