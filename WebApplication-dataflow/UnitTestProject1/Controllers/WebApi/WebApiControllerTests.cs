using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication_dataflow.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebApplication_dataflow.Controllers.Tests
{
    [TestClass()]
    public class WebApiControllerTests
    {
        [TestMethod()]
        public void IsConnectedTest()
        {
            WebApiController api = new WebApiController();

            bool result = api.IsConnected(true);

            Assert.IsTrue(result);
        }
    }
}