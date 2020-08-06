using CQRS_Playground.Controllers;
using CQRS_Playground.RequestModels.CommandRequestModels;
using CQRS_Playground.RequestModels.QueryRequestModels;
using CQRS_Playground.ResponseModels.CommandResponseModels;
using CQRS_Playground.ResponseModels.QueryResponseModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Playground.Test
{
    [TestClass]
    public class OrdersControllerTest
    {
        private Mock<IMediator> _mediator;
        public OrdersControllerTest() => _mediator = new Mock<IMediator>();

        [TestInitialize]
        public void Initialize()
        {
            _mediator.Setup(x => x.Send(It.IsAny<MakeOrderRequestModel>(), new CancellationToken()))
            .ReturnsAsync(new MakeOrderResponseModel 
            { 
                IsSuccessful = true, 
                OrderId = new System.Guid() 
            });
            _mediator.Setup(x => x.Send(It.IsAny<GetOrderByIdRequestModel>(), new CancellationToken()))
            .ReturnsAsync(new GetOrderByIdResponseModel());
        }

        [TestMethod]
        public async Task Does_MakeOrder_Work_Correctly()
        {
            var model = new MakeOrderRequestModel();
            var controller = new OrdersController(_mediator.Object);
            var res = await controller.MakeOrder(model);
            if (res is OkObjectResult)
                Assert.IsTrue(res is OkObjectResult);
            else Assert.Fail("Something went wrong");
        }

        [TestMethod]
        public async Task Does_OrderDetails_Work_Correctly()
        {
            var model = new GetOrderByIdRequestModel();
            var controller = new OrdersController(_mediator.Object);
            var res = await controller.OrderDetails(model);
            if (res is OkObjectResult)
                Assert.IsTrue(res is OkObjectResult);
            else Assert.Fail("Something went wrong");
        }
    }
}
