using CQRS_Playground.ResponseModels.QueryResponseModels;
using MediatR;
using System;

namespace CQRS_Playground.RequestModels.QueryRequestModels
{
    public class GetOrderByIdRequestModel : IRequest<GetOrderByIdResponseModel>
    {
        public Guid OrderId { get; set; }
    }
}
