using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericWinformTemplate.Services.Impl
{
    public class TestService : ITestService
    {
        public Task SayHello(string message)
        {
            MessageBox.Show(message); 
            
            return Task.CompletedTask;
        }
    }
}
