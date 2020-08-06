using CQRS_Playground.Interfaces.ICommandHandlers;
using CQRS_Playground.RequestModels.CommandRequestModels;
using CQRS_Playground.ResponseModels.CommandResponseModels;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Playground.Handlers.CommandHandlers
{
    public class MakeOrderCommandHandler : IRequestHandler<MakeOrderRequestModel, MakeOrderResponseModel> /*IMakeOrderCommandHandler*/
    {
        public Task<MakeOrderResponseModel> Handle(MakeOrderRequestModel request, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                var model = new MakeOrderResponseModel
                {
                    IsSuccessful = true,
                    OrderId = Guid.NewGuid()
                };
                return model;
            });
        }

        //Task<MakeOrderResponseModel> IMakeOrderCommandHandler.MakeOrder(MakeOrderRequestModel requestModel)
        //{
        //    return Task.Run(() =>
        //    {
        //        var model = new MakeOrderResponseModel
        //        {
        //            IsSuccessful = true,
        //            OrderId = Guid.NewGuid()
        //        };
        //        return model;
        //    });
        //}
    }
}
