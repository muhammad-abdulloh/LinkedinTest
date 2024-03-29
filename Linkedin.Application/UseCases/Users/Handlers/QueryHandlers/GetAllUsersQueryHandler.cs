using Linkedin.Application.Abstractions;
using Linkedin.Application.UseCases.Users.Queries;
using Linkedin.Domain.Entities.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.Application.UseCases.Users.Handlers.QueryHandlers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<User>>
    {
        private readonly ILinkedinDbContext _context;

        public GetAllUsersQueryHandler(ILinkedinDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }
    }
}
