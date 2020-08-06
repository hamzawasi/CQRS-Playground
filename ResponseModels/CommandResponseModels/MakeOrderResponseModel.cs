using System;

namespace CQRS_Playground.ResponseModels.CommandResponseModels
{
    public class MakeOrderResponseModel
    {
        public bool IsSuccessful { get; set; }
        public Guid OrderId { get; set; }
    }
}
