using CQRS_Playground.RequestModels.CommandRequestModels;
using CQRS_Playground.ResponseModels.CommandResponseModels;
using System.Threading.Tasks;

namespace CQRS_Playground.Interfaces.ICommandHandlers
{
    public interface IMakeOrderCommandHandler
    {
        Task<MakeOrderResponseModel> MakeOrder(MakeOrderRequestModel requestModel);
    }
}