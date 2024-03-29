using Linkedin.Application.Abstractions;
using Linkedin.Application.UseCases.Users.Commands;
using MediatR;

namespace Linkedin.Application.UseCases.Users.Handlers.CommandHandlers
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly ILinkedinDbContext _context;

        public DeleteUserHandler(ILinkedinDbContext context)
        {
            _context = context;
        }
        public  Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var DeletingUser = _context.Users.Find(request.Id);

            if(DeletingUser == null)
            {
                     return Task.FromResult(false);
            }

            DeletingUser.IsDeleted = true;
            DeletingUser.DeletedDate = DateTime.UtcNow;

            _context.Users.Update(DeletingUser);
            _context.SaveChangesAsync(cancellationToken);

            return Task.FromResult(true);

        }
    }
}
