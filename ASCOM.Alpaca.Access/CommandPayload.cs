﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASCOM.Alpaca.Access
{
    public class CommandPayload : Payload
    {
        public string Command
        {
            get;
            set;
        }

        public bool Raw
        {
            get;
            set;
        } = false;
    }
}
