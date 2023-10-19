using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    interface IPrintSegregated
    {
        bool PrintContent(string content);  //minimum printer perform all three operation .
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);


    }

    // and advance printer can perform fax and prontduplex operation
    interface IFaxContent
    {
        bool FaXContent(string content);
    }
    interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
}
