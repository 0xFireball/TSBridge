using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSBridge
{
    enum ByteOrderMark
    {
        None = 0,
        Utf8 = 1,
        Utf16BigEndian = 2,
        Utf16LittleEndian = 3,
    }
}
