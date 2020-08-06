using CQRS_Playground.RequestModels.CommandRequestModels;
using CQRS_Playground.RequestModels.QueryRequestModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRS_Playground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        //private readonly IGetOrderByIdQueryHandler _getOrderByIdQueryHandler;
        //private readonly IMakeOrderCommandHandler _makeOrderCommandHandler;
        private readonly IMediator _mediator;

        //public OrdersController(IGetOrderByIdQueryHandler getOrderByIdQueryHandler, IMakeOrderCommandHandler makeOrderCommandHandler)
        //{
        //    _getOrderByIdQueryHandler = getOrderByIdQueryHandler;
        //    _makeOrderCommandHandler = makeOrderCommandHandler;
        //}

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> MakeOrder([FromBody] MakeOrderRequestModel model)
        {
            //var res = await _makeOrderCommandHandler.MakeOrder(model);
            var res = await _mediator.Send(model);
            if (res.IsSuccessful)
                return Ok(res);
            else return StatusCode(500);
        }

        public async Task<IActionResult> OrderDetails([FromQuery] GetOrderByIdRequestModel model)
        {
            //var res = await _getOrderByIdQueryHandler.GetOrderById(model);
            var res = await _mediator.Send(model);
            return Ok(res);
        }
    }
}
