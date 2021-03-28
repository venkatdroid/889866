using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public interface ILeaveRequestHandler
    {
         ILeaveRequestHandler nextHandler { get; set; }

         void HandleRequest(LeaveRequest leave);
    }
}
