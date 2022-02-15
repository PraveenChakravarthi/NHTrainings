using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChakriLibrary;

namespace PublicLibrary
{
    // Author : Praveen Chakravarthi
    // Purpose : PublicLibrary for testing Access Modifiers
    public class PLBase : Base   // PublicBase Class inherited by ChakriBase Class
    {
        /// <summary>
        /// This Method Reads Data from Public Base Class
        /// </summary>
        public void ReadPBaseData()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
        }
    }
        public class PLOther // PublicOther Class
    {
        /// <summary>
        /// This Method Reads Data from Public Other Class
        /// </summary>
        public void ReadPOtherData()
        {
            Base B = new Base();
            B.a = 1;
            B.b = 2;
            B.c = 3;
            B.d = 4;
            B.e = 5;
        }
    }
}
