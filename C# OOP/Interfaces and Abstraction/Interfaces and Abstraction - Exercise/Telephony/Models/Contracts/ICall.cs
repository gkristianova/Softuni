using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Models.Contracts
{
    public interface ICall
    {
        public void Call(string number);
    }
}
