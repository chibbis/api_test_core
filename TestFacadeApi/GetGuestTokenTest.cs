using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFacadeApi
{
    [TestClass]
    public class GetGuestTokenTest
    {
        [TestMethod]
        [DataRow("123456789test", "ios")]
        public void GetGuestToken(string device_id, string client_code)
        {
            
        }
    }
}
