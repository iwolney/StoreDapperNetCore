﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolneyStore.Domain.StoreContext.Enums;

namespace WolneyStore.Domain.StoreContext.Commands.CustomerCommands.Inputs
{
    public class AddAddressCommand
    {
        public Guid Id { get; set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public EAddressType Type { get; private set; }
    }
}
