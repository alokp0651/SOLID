using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo.Client
{
    internal class CannonMG2470 : IPrintTask
    {
        public bool FaxContent(string content)
        {
            throw new NotImplementedException();   // For example  CannonMG2470 cant perform the fax operation still it is inforce to implement all the methods of IPrintTask Interface (this problem is solved by sagregating <--dividing one fat interface to smaller relevant interfaces)
        }

        public bool PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
