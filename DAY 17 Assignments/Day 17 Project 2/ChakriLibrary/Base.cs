using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChakriLibrary
{
    // Author : Praveen Chakravarthi
    // Purpose : ChakriLibrary for Testing of Access Modifiers
    public class Base  // ChakriBase Class
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        /// <summary>
        /// This Method Reads Data from Base Class
        /// </summary>
        public void ReadBaseData()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
        }
    }

    public class Derived : Base  //ChakriDerived Class inherited by Base Class
    {
        /// <summary>
        /// This Methods Read Data from Derived Class
        /// </summary>
        public void ReadDerivedData()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
        }
    }

    public class Other   //ChakriOther Class
    {
        /// <summary>
        /// This Method Reads Data from Other Class 
        /// </summary>
       public void ReadOtherData()
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

