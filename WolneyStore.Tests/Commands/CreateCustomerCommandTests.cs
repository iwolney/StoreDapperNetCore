using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolneyStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;

namespace WolneyStore.Tests.Commands
{
    [TestClass]
    public class CreateCustomerCommandTests
    {
        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Wolney";
            command.LastName = "Rodrigues";
            command.Document = "132165465987";
            command.Email = "wolney@msn.com";
            command.Phone = "1199989844";

            Assert.AreEqual(true, command.Valid());
        }
    }
}
