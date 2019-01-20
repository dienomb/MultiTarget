using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public interface IHello
    {
#if NETSTANDARD
        string SayHello(string mess);
#endif
#if NETFRAMEWORK
        int SayHello(int number);
#endif
    }
}
