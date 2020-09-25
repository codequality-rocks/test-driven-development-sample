using System;

namespace start
{
    internal interface INotficationService
    {
        void SendStatusMessage(Guid orderId);
    }
}