using System;
using System.Collections.Generic;
using System.Text;

namespace ASCOM.Alpaca.Access
{
    public class CommandPayload
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
