using MediatR;

namespace RL.Backend.CQRS.Procedures
{
    public class DeleteAllUsersInProcedureCommand : IRequest
    {
        public int ProcedureId { get; set; }
        public int PlanId { get; set; }
    }
}
