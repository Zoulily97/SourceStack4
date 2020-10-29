using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class DBMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("DBMessage");
        }

        public void send()
        {
            throw new NotImplementedException();
        }
    }
}
