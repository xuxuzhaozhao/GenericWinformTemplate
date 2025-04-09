using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericWinformTemplate.Services
{
    public interface ITestService
    {
        Task SayHello(string message);
    }
}
