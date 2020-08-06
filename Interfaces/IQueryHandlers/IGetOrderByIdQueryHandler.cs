using CQRS_Playground.RequestModels.QueryRequestModels;
using CQRS_Playground.ResponseModels.QueryResponseModels;
using System.Threading.Tasks;

namespace CQRS_Playground.Interfaces.IQueryHandlers
{
    public interface IGetOrderByIdQueryHandler
    {
        Task<GetOrderByIdResponseModel> GetOrderById(GetOrderByIdRequestModel requestModel);
    }
}
