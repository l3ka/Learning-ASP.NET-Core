﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class AccountDto
    {

        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public string AccountType { get; set; }

    }
}
