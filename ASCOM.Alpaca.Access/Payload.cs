using System;
using System.Collections.Generic;
using System.Text;

namespace ASCOM.Alpaca.Access
{
    public class Payload
    {
        public uint? ClientID
        {
            get;
            set;
        }

        public uint? ClientTransactionID
        {
            get;
            set;
        }
    }
}
