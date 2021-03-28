using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ILeaveRequestHandler supervisor = new Supervisor();
            ILeaveRequestHandler manager = new ProjectManager();
            ILeaveRequestHandler hr = new HR();
            supervisor.nextHandler = manager;
            manager.nextHandler = hr;
            LeaveRequest request1 = new LeaveRequest();
            request1.Employee = "Sam";
            request1.LeaveDays = 2;
            Console.WriteLine("Name: {0}  Leavedays: {1}", request1.Employee, request1.LeaveDays);
            supervisor.HandleRequest(request1);
            Console.WriteLine();
            LeaveRequest request2 = new LeaveRequest();
            request2.Employee = "Marcus";
            request2.LeaveDays = 4;
            Console.WriteLine("Name: {0}  Leavedays: {1}", request2.Employee, request2.LeaveDays);
            supervisor.HandleRequest(request2);
            Console.WriteLine();
            LeaveRequest request3 = new LeaveRequest();
            request3.Employee = "John";
            request3.LeaveDays = 8;
            Console.WriteLine("Name: {0}  Leavedays: {1}", request3.Employee, request3.LeaveDays);
            supervisor.HandleRequest(request3);
            Console.Read();
        }
    }
}
