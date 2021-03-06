using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolneyStore.Domain.StoreContext.Commands.CustomerCommands.Inputs
{
    public class CreateCustomerCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
