using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    internal interface IPrintTask
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);
        bool PrintDuplexContent (string content); // with this new addition all the client are mandatory force to implement the newly added method as well (this problem is solved by sagregating <--dividing one fat interface to smaller relevant interfaces)


    }
}
