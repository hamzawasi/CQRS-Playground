 using CQRS_Playground.Interfaces.IQueryHandlers;
using CQRS_Playground.RequestModels.QueryRequestModels;
using CQRS_Playground.ResponseModels.QueryResponseModels;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Playground.Handlers.QueryHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdRequestModel, GetOrderByIdResponseModel> /*IGetOrderByIdQueryHandler*/
    {
        //public Task<GetOrderByIdResponseModel> GetOrderById(GetOrderByIdRequestModel requestModel)
        //{
        //    return Task.Run(() =>
        //    {
        //        var res = new GetOrderByIdResponseModel();
        //        return res;
        //    });
        //}

        public Task<GetOrderByIdResponseModel> Handle(GetOrderByIdRequestModel request, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                var res = new GetOrderByIdResponseModel();
                return res;
            });
        }
    }
}
