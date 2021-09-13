using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    static class InvalidSelectionException : Exception

    {
        public InvalidSelectionException(string Message) : base(Message)
        {
            this.Message = Message;
}

        public string Message { get; }
    }
}
